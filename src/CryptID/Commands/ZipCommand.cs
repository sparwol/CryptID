using System.IO.Compression;
using CryptID.Cli;
using CryptID.Crypto;

namespace CryptID.Commands;

/// <summary>
///   cryptid zip encrypt PATH [PATH...] [--out FILE.czip] [--force] [--pass...]
///   cryptid zip decrypt --in FILE.czip [--out DIR] [--force] [--pass...]
/// Compresses files/folders into a Zip archive, then seals the whole archive with the same
/// authenticated container as `file`. The result (.czip) is produced and read by CryptID; it is
/// NOT a standard password-protected Zip (that trade-off is deliberate — see the README).
/// </summary>
public static class ZipCommand
{
    private const string Ext = ".czip";
    private static readonly HashSet<string> Flags = new(StringComparer.Ordinal) { "force" };

    public static int Run(IReadOnlyList<string> rest)
    {
        if (rest.Count == 0) throw new CryptidException("Usage: cryptid zip <encrypt|decrypt> [options]");
        string action = rest[0];
        var args = ArgMap.Parse(rest.Skip(1).ToList(), Flags);
        bool force = args.Flag("force");

        switch (action)
        {
            case "encrypt": return Encrypt(args, force);
            case "decrypt": return Decrypt(args, force);
            default: throw new CryptidException($"Unknown action '{action}'. Use 'encrypt' or 'decrypt'.");
        }
    }

    private static int Encrypt(ArgMap args, bool force)
    {
        var inputs = new List<string>(args.Positionals);
        string? inOpt = args.Get("in");
        if (inOpt != null) inputs.Add(inOpt);
        if (inputs.Count == 0) throw new CryptidException("Provide at least one file or folder to compress.");
        foreach (var p in inputs)
            if (!File.Exists(p) && !Directory.Exists(p)) throw new CryptidException($"Not found: {p}");

        string outPath = args.Get("out") ?? DefaultArchiveName(inputs[0]);
        Shared.GuardOutput(outPath, force);

        byte[] zipBytes;
        using (var ms = new MemoryStream())
        {
            using (var zip = new ZipArchive(ms, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (string path in inputs)
                {
                    if (Directory.Exists(path))
                    {
                        string root = Path.GetFileName(Path.TrimEndingDirectorySeparator(Path.GetFullPath(path)));
                        foreach (string file in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
                        {
                            string rel = Path.GetRelativePath(path, file).Replace('\\', '/');
                            AddFile(zip, file, $"{root}/{rel}");
                        }
                    }
                    else
                    {
                        AddFile(zip, path, Path.GetFileName(path));
                    }
                }
            }
            zipBytes = ms.ToArray();
        }

        string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: true);
        File.WriteAllBytes(outPath, CryptidContainer.Encrypt(zipBytes, pass));
        Console.Error.WriteLine($"Compressed {inputs.Count} path(s) and encrypted -> {outPath}");
        return 0;
    }

    private static int Decrypt(ArgMap args, bool force)
    {
        string inPath = args.Get("in") ?? (args.Positionals.Count > 0 ? args.Positionals[0]
            : throw new CryptidException("--in FILE.czip is required."));
        if (!File.Exists(inPath)) throw new CryptidException($"Input file not found: {inPath}");
        string outDir = args.Get("out") ?? DefaultExtractDir(inPath);

        string pass = ConsoleIO.ResolvePassphrase(args, confirmIfPrompt: false);
        byte[] zipBytes = CryptidContainer.Decrypt(File.ReadAllBytes(inPath), pass);

        Directory.CreateDirectory(outDir);
        string outFull = Path.GetFullPath(outDir);
        int count = 0;
        using (var ms = new MemoryStream(zipBytes))
        using (var zip = new ZipArchive(ms, ZipArchiveMode.Read))
        {
            foreach (ZipArchiveEntry entry in zip.Entries)
            {
                string dest = Path.GetFullPath(Path.Combine(outDir, entry.FullName));
                // Zip-slip guard: never let an entry escape the output directory.
                if (!dest.StartsWith(outFull + Path.DirectorySeparatorChar, StringComparison.Ordinal) &&
                    !dest.Equals(outFull, StringComparison.Ordinal))
                    throw new CryptidException($"Refusing unsafe archive entry path: {entry.FullName}");

                if (entry.FullName.EndsWith('/'))
                {
                    Directory.CreateDirectory(dest);
                    continue;
                }
                Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
                Shared.GuardOutput(dest, force);
                entry.ExtractToFile(dest, overwrite: force);
                count++;
            }
        }
        Console.Error.WriteLine($"Decrypted and extracted {count} file(s) -> {outDir}");
        return 0;
    }

    private static void AddFile(ZipArchive zip, string filePath, string entryName)
    {
        ZipArchiveEntry entry = zip.CreateEntry(entryName, CompressionLevel.Optimal);
        using Stream es = entry.Open();
        using FileStream fs = File.OpenRead(filePath);
        fs.CopyTo(es);
    }

    private static string DefaultArchiveName(string firstInput)
    {
        string name = Path.GetFileName(Path.TrimEndingDirectorySeparator(Path.GetFullPath(firstInput)));
        return (string.IsNullOrEmpty(name) ? "archive" : name) + Ext;
    }

    private static string DefaultExtractDir(string inPath) =>
        inPath.EndsWith(Ext, StringComparison.OrdinalIgnoreCase) ? inPath[..^Ext.Length] : inPath + ".extracted";
}
