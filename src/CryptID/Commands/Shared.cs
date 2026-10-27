namespace CryptID.Commands;

/// <summary>Small IO helpers shared by the commands.</summary>
internal static class Shared
{
    public static void GuardOutput(string path, bool force)
    {
        if (File.Exists(path) && !force)
            throw new CryptidException($"'{path}' already exists. Use --force to overwrite.");
    }

    public static byte[] ReadAllStdinBytes()
    {
        using var stdin = Console.OpenStandardInput();
        using var ms = new MemoryStream();
        stdin.CopyTo(ms);
        return ms.ToArray();
    }

    public static void WriteBytes(string? outPath, byte[] data)
    {
        if (outPath == null)
        {
            using var stdout = Console.OpenStandardOutput();
            stdout.Write(data, 0, data.Length);
        }
        else
        {
            File.WriteAllBytes(outPath, data);
        }
    }
}
