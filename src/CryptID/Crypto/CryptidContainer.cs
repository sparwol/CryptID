using System.Buffers.Binary;
using System.Security.Cryptography;

namespace CryptID.Crypto;

/// <summary>
/// The one encryption primitive used by every command (text, file, zip). A passphrase is run
/// through a KDF to derive a 256-bit key; the payload is then sealed with AES-256-GCM, which is
/// authenticated — so a wrong passphrase or any tampering is detected on decrypt rather than
/// silently returning garbage. Salt and nonce are random per message, so encrypting the same
/// input twice yields different output, and all parameters needed to decrypt are stored in the
/// header (only the passphrase is secret).
///
/// Container layout (big-endian), header fields are authenticated as GCM associated data:
///   MAGIC   8  "CRYPTID1"
///   VERSION 1  = 1
///   KDF_ID  1  = 1 (PBKDF2-HMAC-SHA256)
///   ITER    4  uint32 KDF iterations
///   SALTLEN 1  salt length (= 16)
///   SALT    SALTLEN
///   NONCE   12 GCM nonce
///   TAG     16 GCM authentication tag
///   CIPHERTEXT  remainder
///
/// This format is NOT compatible with the original 2020 WinForms build (which derived a
/// deterministic key/IV from an unsalted SHA-256 of the passphrase and used unauthenticated
/// AES-CBC). The weaknesses that made that worth replacing are exactly what this fixes.
/// </summary>
public static class CryptidContainer
{
    private static readonly byte[] Magic = "CRYPTID1"u8.ToArray();
    private const byte Version = 1;
    private const byte KdfPbkdf2Sha256 = 1;
    private const int SaltLen = 16;
    private const int NonceLen = 12; // AES-GCM standard nonce
    private const int TagLen = 16;   // AES-GCM standard tag
    private const int KeyLen = 32;   // AES-256

    /// <summary>OWASP-recommended floor for PBKDF2-HMAC-SHA256; stored in the header so it can rise later.</summary>
    public const int DefaultIterations = 600_000;

    public static byte[] Encrypt(ReadOnlySpan<byte> plaintext, string passphrase, int iterations = DefaultIterations)
    {
        if (string.IsNullOrEmpty(passphrase)) throw new CryptidException("A passphrase is required.");
        if (iterations < 1) throw new CryptidException("Iterations must be positive.");

        byte[] salt = RandomNumberGenerator.GetBytes(SaltLen);
        byte[] nonce = RandomNumberGenerator.GetBytes(NonceLen);
        byte[] key = DeriveKey(passphrase, salt, iterations);

        byte[] header = BuildHeader(iterations, salt, nonce);
        byte[] tag = new byte[TagLen];
        byte[] ciphertext = new byte[plaintext.Length];

        try
        {
            using var gcm = new AesGcm(key, TagLen);
            gcm.Encrypt(nonce, plaintext, ciphertext, tag, header); // header authenticated as AAD
        }
        finally
        {
            CryptographicOperations.ZeroMemory(key);
        }

        byte[] output = new byte[header.Length + TagLen + ciphertext.Length];
        Buffer.BlockCopy(header, 0, output, 0, header.Length);
        Buffer.BlockCopy(tag, 0, output, header.Length, TagLen);
        Buffer.BlockCopy(ciphertext, 0, output, header.Length + TagLen, ciphertext.Length);
        return output;
    }

    public static byte[] Decrypt(ReadOnlySpan<byte> container, string passphrase)
    {
        if (string.IsNullOrEmpty(passphrase)) throw new CryptidException("A passphrase is required.");

        int pos = 0;
        ReadOnlySpan<byte> Take(int n, string what)
        {
            if (pos + n > container.Length) throw new CryptidException($"Corrupt or truncated data (reading {what}).");
            var s = container.Slice(pos, n);
            pos += n;
            return s;
        }

        if (!Take(Magic.Length, "magic").SequenceEqual(Magic))
            throw new CryptidException("Not a CryptID container (bad magic bytes).");
        byte version = Take(1, "version")[0];
        if (version != Version) throw new CryptidException($"Unsupported container version {version}.");
        byte kdf = Take(1, "kdf id")[0];
        if (kdf != KdfPbkdf2Sha256) throw new CryptidException($"Unsupported KDF id {kdf}.");
        uint iterations = BinaryPrimitives.ReadUInt32BigEndian(Take(4, "iterations"));
        if (iterations < 1) throw new CryptidException("Invalid iteration count in header.");
        byte saltLen = Take(1, "salt length")[0];
        byte[] salt = Take(saltLen, "salt").ToArray();
        byte[] nonce = Take(NonceLen, "nonce").ToArray();

        int headerLen = pos;
        byte[] header = container.Slice(0, headerLen).ToArray();
        byte[] tag = Take(TagLen, "tag").ToArray();
        byte[] ciphertext = container.Slice(pos).ToArray();

        byte[] key = DeriveKey(passphrase, salt, (int)iterations);
        byte[] plaintext = new byte[ciphertext.Length];
        try
        {
            using var gcm = new AesGcm(key, TagLen);
            gcm.Decrypt(nonce, ciphertext, tag, plaintext, header);
        }
        catch (AuthenticationTagMismatchException)
        {
            throw new CryptidException("Decryption failed: wrong passphrase or the data has been modified.");
        }
        finally
        {
            CryptographicOperations.ZeroMemory(key);
        }
        return plaintext;
    }

    private static byte[] DeriveKey(string passphrase, byte[] salt, int iterations) =>
        Rfc2898DeriveBytes.Pbkdf2(passphrase, salt, iterations, HashAlgorithmName.SHA256, KeyLen);

    private static byte[] BuildHeader(int iterations, byte[] salt, byte[] nonce)
    {
        int len = Magic.Length + 1 + 1 + 4 + 1 + salt.Length + nonce.Length;
        byte[] h = new byte[len];
        int p = 0;
        Buffer.BlockCopy(Magic, 0, h, p, Magic.Length); p += Magic.Length;
        h[p++] = Version;
        h[p++] = KdfPbkdf2Sha256;
        BinaryPrimitives.WriteUInt32BigEndian(h.AsSpan(p, 4), (uint)iterations); p += 4;
        h[p++] = (byte)salt.Length;
        Buffer.BlockCopy(salt, 0, h, p, salt.Length); p += salt.Length;
        Buffer.BlockCopy(nonce, 0, h, p, nonce.Length);
        return h;
    }
}
