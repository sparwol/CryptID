using System.Text;

namespace CryptID.Cli;

/// <summary>Console helpers. Prompts go to stderr so stdout stays clean for piping ciphertext.</summary>
public static class ConsoleIO
{
    /// <summary>
    /// Resolve a passphrase from (in order): --pass VALUE, --pass-env NAME, or an interactive
    /// no-echo prompt. On encrypt the interactive prompt asks for confirmation.
    /// </summary>
    public static string ResolvePassphrase(ArgMap args, bool confirmIfPrompt)
    {
        string? direct = args.Get("pass");
        if (direct != null) return direct.Length > 0 ? direct : throw new CryptidException("--pass was empty.");

        string? envName = args.Get("pass-env");
        if (envName != null)
        {
            string? v = Environment.GetEnvironmentVariable(envName);
            if (string.IsNullOrEmpty(v)) throw new CryptidException($"Environment variable '{envName}' is unset or empty.");
            return v;
        }

        if (Console.IsInputRedirected)
        {
            string? line = Console.In.ReadLine();
            if (string.IsNullOrEmpty(line)) throw new CryptidException("No passphrase provided on stdin.");
            return line;
        }

        string p1 = ReadHidden("Passphrase: ");
        if (p1.Length == 0) throw new CryptidException("Passphrase cannot be empty.");
        if (confirmIfPrompt)
        {
            string p2 = ReadHidden("Confirm passphrase: ");
            if (!string.Equals(p1, p2, StringComparison.Ordinal)) throw new CryptidException("Passphrases did not match.");
        }
        return p1;
    }

    private static string ReadHidden(string prompt)
    {
        Console.Error.Write(prompt);
        var sb = new StringBuilder();
        while (true)
        {
            ConsoleKeyInfo k = Console.ReadKey(intercept: true);
            if (k.Key == ConsoleKey.Enter) { Console.Error.WriteLine(); break; }
            if (k.Key == ConsoleKey.Backspace)
            {
                if (sb.Length > 0) sb.Length--;
                continue;
            }
            if (!char.IsControl(k.KeyChar)) sb.Append(k.KeyChar);
        }
        return sb.ToString();
    }
}
