using System.Text;
using CryptID;
using CryptID.Crypto;
using Xunit;

namespace CryptID.Tests;

public class ContainerTests
{
    private static readonly byte[] Sample = Encoding.UTF8.GetBytes("The quick brown fox jumps over 13 lazy dogs. 🦊");

    [Fact]
    public void RoundTrip_ReturnsOriginal()
    {
        byte[] ct = CryptidContainer.Encrypt(Sample, "correct horse battery staple", iterations: 50_000);
        byte[] pt = CryptidContainer.Decrypt(ct, "correct horse battery staple");
        Assert.Equal(Sample, pt);
    }

    [Fact]
    public void Empty_PlaintextRoundTrips()
    {
        byte[] ct = CryptidContainer.Encrypt(ReadOnlySpan<byte>.Empty, "pw", iterations: 50_000);
        Assert.Empty(CryptidContainer.Decrypt(ct, "pw"));
    }

    [Fact]
    public void WrongPassphrase_Throws()
    {
        byte[] ct = CryptidContainer.Encrypt(Sample, "right", iterations: 50_000);
        var ex = Assert.Throws<CryptidException>(() => CryptidContainer.Decrypt(ct, "wrong"));
        Assert.Contains("wrong passphrase", ex.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void TamperedCiphertext_Throws()
    {
        byte[] ct = CryptidContainer.Encrypt(Sample, "pw", iterations: 50_000);
        ct[^1] ^= 0xFF; // flip a byte of the ciphertext
        Assert.Throws<CryptidException>(() => CryptidContainer.Decrypt(ct, "pw"));
    }

    [Fact]
    public void TamperedHeader_Throws()
    {
        byte[] ct = CryptidContainer.Encrypt(Sample, "pw", iterations: 50_000);
        ct[9] ^= 0x01; // flip a KDF/iteration header byte (authenticated as AAD)
        Assert.Throws<CryptidException>(() => CryptidContainer.Decrypt(ct, "pw"));
    }

    [Fact]
    public void SameInput_ProducesDifferentCiphertext()
    {
        byte[] a = CryptidContainer.Encrypt(Sample, "pw", iterations: 50_000);
        byte[] b = CryptidContainer.Encrypt(Sample, "pw", iterations: 50_000);
        Assert.NotEqual(a, b); // random salt + nonce each time
    }

    [Fact]
    public void BadMagic_Throws()
    {
        var ex = Assert.Throws<CryptidException>(() => CryptidContainer.Decrypt(new byte[] { 1, 2, 3 }, "pw"));
        Assert.Contains("CryptID container", ex.Message);
    }

    [Fact]
    public void EmptyPassphrase_Throws()
    {
        Assert.Throws<CryptidException>(() => CryptidContainer.Encrypt(Sample, "", iterations: 50_000));
    }
}

public class PasswordGeneratorTests
{
    [Fact]
    public void Length_IsHonored()
    {
        Assert.Equal(32, PasswordGenerator.Generate(32, true, true, true, true, false).Length);
    }

    [Fact]
    public void IncludesEachRequestedClass()
    {
        for (int i = 0; i < 50; i++)
        {
            string pw = PasswordGenerator.Generate(8, lower: true, upper: true, digits: true, symbols: true, excludeAmbiguous: false);
            Assert.Contains(pw, c => PasswordGenerator.Lower.Contains(c));
            Assert.Contains(pw, c => PasswordGenerator.Upper.Contains(c));
            Assert.Contains(pw, c => PasswordGenerator.Digits.Contains(c));
            Assert.Contains(pw, c => PasswordGenerator.Symbols.Contains(c));
        }
    }

    [Fact]
    public void DigitsOnly_ProducesOnlyDigits()
    {
        string pw = PasswordGenerator.Generate(40, lower: false, upper: false, digits: true, symbols: false, excludeAmbiguous: false);
        Assert.All(pw, c => Assert.Contains(c, PasswordGenerator.Digits));
    }

    [Fact]
    public void ExcludeAmbiguous_OmitsConfusables()
    {
        string pw = PasswordGenerator.Generate(200, true, true, true, false, excludeAmbiguous: true);
        Assert.DoesNotContain('0', pw);
        Assert.DoesNotContain('O', pw);
        Assert.DoesNotContain('l', pw);
    }

    [Fact]
    public void TooShortForAllClasses_Throws()
    {
        Assert.Throws<CryptidException>(() => PasswordGenerator.Generate(2, true, true, true, true, false));
    }

    [Fact]
    public void NoClasses_Throws()
    {
        Assert.Throws<CryptidException>(() => PasswordGenerator.Generate(10, false, false, false, false, false));
    }
}
