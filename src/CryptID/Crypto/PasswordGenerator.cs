using System.Security.Cryptography;
using System.Text;

namespace CryptID.Crypto;

/// <summary>
/// Random password generation using a cryptographically secure RNG (the original used
/// System.Random, which is not safe for secrets). When several character classes are requested,
/// the result is guaranteed to contain at least one character from each, then shuffled.
/// </summary>
public static class PasswordGenerator
{
    public const string Lower = "abcdefghijklmnopqrstuvwxyz";
    public const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public const string Digits = "0123456789";
    public const string Symbols = "!@#$%^&*()-_=+[]{};:,.?";
    // Characters easy to confuse in print; removed when --no-ambiguous is set.
    private const string Ambiguous = "O0oIl1|";

    public static string Generate(int length, bool lower, bool upper, bool digits, bool symbols, bool excludeAmbiguous)
    {
        if (length < 1) throw new CryptidException("Password length must be at least 1.");

        var classes = new List<string>();
        if (lower) classes.Add(Filter(Lower, excludeAmbiguous));
        if (upper) classes.Add(Filter(Upper, excludeAmbiguous));
        if (digits) classes.Add(Filter(Digits, excludeAmbiguous));
        if (symbols) classes.Add(Filter(Symbols, excludeAmbiguous));
        if (classes.Count == 0) throw new CryptidException("At least one character class must be enabled.");
        if (length < classes.Count)
            throw new CryptidException($"Length {length} is too short to include all {classes.Count} selected character classes.");

        string pool = string.Concat(classes);
        var chars = new char[length];
        int i = 0;
        foreach (var cls in classes) chars[i++] = Pick(cls); // one guaranteed from each class
        for (; i < length; i++) chars[i] = Pick(pool);

        Shuffle(chars);
        return new string(chars);
    }

    private static string Filter(string set, bool excludeAmbiguous)
    {
        if (!excludeAmbiguous) return set;
        var sb = new StringBuilder(set.Length);
        foreach (char c in set) if (!Ambiguous.Contains(c)) sb.Append(c);
        if (sb.Length == 0) throw new CryptidException("A character class became empty after excluding ambiguous characters.");
        return sb.ToString();
    }

    private static char Pick(string set) => set[RandomNumberGenerator.GetInt32(set.Length)];

    private static void Shuffle(char[] a)
    {
        // Fisher–Yates with a uniform CSPRNG index.
        for (int n = a.Length - 1; n > 0; n--)
        {
            int j = RandomNumberGenerator.GetInt32(n + 1);
            (a[n], a[j]) = (a[j], a[n]);
        }
    }
}
