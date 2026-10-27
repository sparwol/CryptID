namespace CryptID.Cli;

/// <summary>
/// A tiny option parser (no external dependency). Accepts <c>--name value</c>, <c>--name=value</c>,
/// and boolean <c>--flag</c> forms; anything not starting with <c>--</c> is positional. Boolean
/// flags are declared per command so a value-taking option is never mistaken for a flag.
/// </summary>
public sealed class ArgMap
{
    private readonly Dictionary<string, string> _options = new(StringComparer.Ordinal);
    private readonly HashSet<string> _flags = new(StringComparer.Ordinal);
    public List<string> Positionals { get; } = new();

    public static ArgMap Parse(IReadOnlyList<string> tokens, ISet<string> knownFlags)
    {
        var m = new ArgMap();
        for (int i = 0; i < tokens.Count; i++)
        {
            string t = tokens[i];
            if (t.StartsWith("--", StringComparison.Ordinal))
            {
                string name = t[2..];
                int eq = name.IndexOf('=');
                if (eq >= 0)
                {
                    m._options[name[..eq]] = name[(eq + 1)..];
                }
                else if (knownFlags.Contains(name))
                {
                    m._flags.Add(name);
                }
                else
                {
                    if (i + 1 >= tokens.Count) throw new CryptidException($"Option --{name} requires a value.");
                    m._options[name] = tokens[++i];
                }
            }
            else
            {
                m.Positionals.Add(t);
            }
        }
        return m;
    }

    public string? Get(string name) => _options.TryGetValue(name, out var v) ? v : null;
    public bool Flag(string name) => _flags.Contains(name);

    public int GetInt(string name, int fallback)
    {
        string? v = Get(name);
        if (v == null) return fallback;
        if (!int.TryParse(v, out int n)) throw new CryptidException($"--{name} must be a whole number.");
        return n;
    }
}
