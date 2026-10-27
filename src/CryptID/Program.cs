using CryptID;
using CryptID.Commands;

const string Usage = """
CryptID — passphrase-based encryption tool

USAGE
  cryptid <command> [options]

COMMANDS
  text encrypt|decrypt   Encrypt/decrypt a string (ciphertext is Base64, for pasting)
  file encrypt|decrypt   Encrypt/decrypt a file
  zip  encrypt|decrypt   Compress files/folders into one encrypted archive, and extract it
  genpass                Generate random passwords with a secure RNG
  help, --help, -h       Show this help
  version, --version     Show version

PASSPHRASE (supplied per operation; there is no login or stored password)
  --pass VALUE           Passphrase on the command line (visible to other users; avoid)
  --pass-env NAME        Read the passphrase from environment variable NAME
  (otherwise)            Prompt without echo; encryption asks for confirmation

EXAMPLES
  cryptid text encrypt --text "meet at noon" > secret.txt
  cryptid text decrypt --in secret.txt
  cryptid file encrypt --in report.pdf                 # -> report.pdf.cryptid
  cryptid file decrypt --in report.pdf.cryptid
  cryptid zip encrypt ./project --out project.czip
  cryptid zip decrypt --in project.czip --out ./restored
  cryptid genpass --length 24 --count 5 --no-ambiguous

Encryption: PBKDF2-HMAC-SHA256 key derivation (random salt) + AES-256-GCM (random nonce,
authenticated). Wrong passphrase or modified data is detected and refused.
""";

try
{
    if (args.Length == 0) { Console.Error.WriteLine(Usage); return 1; }

    string command = args[0];
    IReadOnlyList<string> rest = args.Skip(1).ToList();

    return command switch
    {
        "text" => TextCommand.Run(rest),
        "file" => FileCommand.Run(rest),
        "zip" => ZipCommand.Run(rest),
        "genpass" => GenPassCommand.Run(rest),
        "help" or "--help" or "-h" => Print(Usage),
        "version" or "--version" or "-v" => Print($"cryptid {ThisVersion()}"),
        _ => Unknown(command),
    };
}
catch (CryptidException ex)
{
    Console.Error.WriteLine($"error: {ex.Message}");
    return 1;
}
catch (UnauthorizedAccessException ex)
{
    Console.Error.WriteLine($"error: {ex.Message}");
    return 1;
}
catch (IOException ex)
{
    Console.Error.WriteLine($"error: {ex.Message}");
    return 1;
}

static int Print(string s) { Console.Out.WriteLine(s); return 0; }

static int Unknown(string command)
{
    Console.Error.WriteLine($"error: unknown command '{command}'. Run 'cryptid help'.");
    return 1;
}

static string ThisVersion() =>
    typeof(Program).Assembly.GetName().Version?.ToString(3) ?? "1.0.0";
