using CryptID.Cli;
using CryptID.Crypto;

namespace CryptID.Commands;

/// <summary>
///   cryptid genpass [--length N] [--count N] [--no-lower] [--no-upper] [--no-digits]
///                   [--no-symbols] [--no-ambiguous]
/// Prints one password per line. All four character classes are on by default.
/// </summary>
public static class GenPassCommand
{
    private static readonly HashSet<string> Flags = new(StringComparer.Ordinal)
        { "no-lower", "no-upper", "no-digits", "no-symbols", "no-ambiguous" };

    public static int Run(IReadOnlyList<string> rest)
    {
        var args = ArgMap.Parse(rest, Flags);
        int length = args.GetInt("length", 20);
        int count = args.GetInt("count", 1);
        if (count < 1) throw new CryptidException("--count must be at least 1.");

        bool lower = !args.Flag("no-lower");
        bool upper = !args.Flag("no-upper");
        bool digits = !args.Flag("no-digits");
        bool symbols = !args.Flag("no-symbols");
        bool excludeAmbiguous = args.Flag("no-ambiguous");

        for (int i = 0; i < count; i++)
            Console.Out.WriteLine(PasswordGenerator.Generate(length, lower, upper, digits, symbols, excludeAmbiguous));
        return 0;
    }
}
