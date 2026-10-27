using CryptID.Cli;
using CryptID.Crypto;

namespace CryptID.Commands;

/// <summary>
///   cryptid file encrypt --in FILE [--out FILE] [--force] [--pass...]
///   cryptid file decrypt --in FILE [--out FILE] [--force] [--pass...]
/// Default output: encrypt -> "FILE.cryptid"; decrypt -> the name with ".cryptid" removed, or
/// "FILE.dec" if it had no such suffix. The whole file is processed in memory (see README note).
/// </summary>
public static class FileCommand
{
    private const string Ext = ".cryptid";
    private static readonly HashSet<string> Flags = new(StringComparer.Ordinal) { "force" };

    public static int Run(IReadOnlyList<string> rest)
    {
        if (rest.Count == 0) throw new CryptidException("Usage: cryptid file <encrypt|decrypt> --in FILE [options]");
        string action = rest[0];
        var args = ArgMap.Parse(rest.Skip(1).ToList(), Flags);

        string inPath = args.Get("in") ?? (args.Positionals.Count > 0 ? args.Positionals[0]
            : throw new CryptidException("--in FILE is required."));
        if (!File.Exists(inPath)) throw new CryptidException($"Input file not found: {inPath}");
        bool force = args.Flag("force");

        switch (action)
        {
            case "encrypt":
            {
                string outPath = args.Get("out") ?? inPath + Ext;
                Shared.GuardOutput(outPath, force);
                string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: true);
                byte[] container = CryptidContainer.Encrypt(File.ReadAllBytes(inPath), pass);
                File.WriteAllBytes(outPath, container);
                Console.Error.WriteLine($"Encrypted -> {outPath}");
                return 0;
            }
            case "decrypt":
            {
                string outPath = args.Get("out") ?? DefaultDecryptName(inPath);
                Shared.GuardOutput(outPath, force);
                string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: false);
                byte[] plain = CryptidContainer.Decrypt(File.ReadAllBytes(inPath), pass);
                File.WriteAllBytes(outPath, plain);
                Console.Error.WriteLine($"Decrypted -> {outPath}");
                return 0;
            }
            default:
                throw new CryptidException($"Unknown action '{action}'. Use 'encrypt' or 'decrypt'.");
        }
    }

    private static string DefaultDecryptName(string inPath) =>
        inPath.EndsWith(Ext, StringComparison.OrdinalIgnoreCase) ? inPath[..^Ext.Length] : inPath + ".dec";
}
