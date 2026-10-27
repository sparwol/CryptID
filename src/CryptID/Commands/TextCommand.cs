using System.Text;
using CryptID.Cli;
using CryptID.Crypto;

namespace CryptID.Commands;

/// <summary>
///   cryptid text encrypt [--text STR | --in FILE | STDIN] [--out FILE] [--pass... ]
///   cryptid text decrypt [--text STR | --in FILE | STDIN] [--out FILE] [--pass... ]
/// Ciphertext is Base64 so it can be pasted into a message; decrypt tolerates surrounding whitespace.
/// </summary>
public static class TextCommand
{
    private static readonly HashSet<string> Flags = new(StringComparer.Ordinal);

    public static int Run(IReadOnlyList<string> rest)
    {
        if (rest.Count == 0) throw new CryptidException("Usage: cryptid text <encrypt|decrypt> [options]");
        string action = rest[0];
        var args = ArgMap.Parse(rest.Skip(1).ToList(), Flags);
        string input = ReadText(args);

        switch (action)
        {
            case "encrypt":
            {
                string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: true);
                byte[] container = CryptidContainer.Encrypt(Encoding.UTF8.GetBytes(input), pass);
                WriteText(args.Get("out"), Convert.ToBase64String(container));
                return 0;
            }
            case "decrypt":
            {
                string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: false);
                byte[] container = FromBase64(input);
                byte[] plain = CryptidContainer.Decrypt(container, pass);
                WriteText(args.Get("out"), Encoding.UTF8.GetString(plain));
                return 0;
            }
            default:
                throw new CryptidException($"Unknown action '{action}'. Use 'encrypt' or 'decrypt'.");
        }
    }

    private static string ReadText(ArgMap args)
    {
        string? inline = args.Get("text");
        if (inline != null) return inline;
        string? inFile = args.Get("in");
        if (inFile != null) return File.ReadAllText(inFile);
        if (args.Positionals.Count > 0) return args.Positionals[0];
        if (Console.IsInputRedirected) return Console.In.ReadToEnd();
        throw new CryptidException("No input text. Provide --text, --in FILE, a positional string, or pipe stdin.");
    }

    private static byte[] FromBase64(string s)
    {
        try { return Convert.FromBase64String(s.Trim()); }
        catch (FormatException) { throw new CryptidException("Input is not valid Base64 ciphertext."); }
    }

    private static void WriteText(string? outPath, string text)
    {
        if (outPath == null) Console.Out.WriteLine(text);
        else File.WriteAllText(outPath, text);
    }
}
