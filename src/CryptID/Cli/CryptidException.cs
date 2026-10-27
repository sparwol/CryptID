namespace CryptID;

/// <summary>A user-facing error: its message is printed to stderr and the process exits 1,
/// without a stack trace. Thrown for bad input, bad passphrase, or tampered data.</summary>
public sealed class CryptidException : Exception
{
    public CryptidException(string message) : base(message) { }
}
