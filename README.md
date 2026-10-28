# CryptID

A cross-platform command-line encryption tool. A rewrite of the original 2020 C#/WinForms
CryptID as a .NET 8 console app.

There is **no login and no database**. A passphrase is supplied with each operation; nothing is
stored. The old SQL-LocalDB login (which held plaintext passwords) has been removed entirely.

## Build and run

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet build -c Release
dotnet run --project src/CryptID -- help
# or publish a single executable:
dotnet publish src/CryptID -c Release -o dist
./dist/cryptid help
```

Run the tests:

```bash
dotnet test
```

## Commands

```
cryptid text encrypt|decrypt   Encrypt/decrypt a string (Base64 output, for pasting)
cryptid file encrypt|decrypt   Encrypt/decrypt a file
cryptid zip  encrypt|decrypt   Compress files/folders into one encrypted archive, and extract it
cryptid genpass                Generate random passwords (secure RNG)
cryptid help | version
```

### Passphrase (supplied per operation)

In order of precedence:

- `--pass VALUE` — on the command line. Visible to other users via the process list; avoid except in throwaway cases.
- `--pass-env NAME` — read from an environment variable (good for scripts/CI).
- otherwise — prompt without echo. Encryption asks you to confirm.

When piping data on stdin, supply the passphrase with `--pass`/`--pass-env` (stdin is then the data, not the passphrase).

### Examples

```bash
# Text (ciphertext is Base64)
cryptid text encrypt --text "meet at noon" > secret.txt
cryptid text decrypt --in secret.txt

# File (default output adds .cryptid)
cryptid file encrypt --in report.pdf
cryptid file decrypt --in report.pdf.cryptid --out report.pdf

# Folder -> one encrypted archive, then extract
cryptid zip encrypt ./project --out project.czip
cryptid zip decrypt --in project.czip --out ./restored

# Passwords
cryptid genpass --length 24
cryptid genpass --length 20 --count 5 --no-ambiguous
cryptid genpass --length 16 --no-symbols
```

`genpass` flags: `--length N` (default 20), `--count N` (default 1), and `--no-lower`,
`--no-upper`, `--no-digits`, `--no-symbols`, `--no-ambiguous`.

Overwriting an existing output requires `--force` (on `file` and `zip`).

## How encryption works

Every command uses one authenticated container:

1. **Key derivation:** PBKDF2-HMAC-SHA256 over the passphrase with a random 16-byte salt and
   600,000 iterations (the OWASP floor for this KDF), producing a 256-bit key.
2. **Encryption:** AES-256-GCM with a random 12-byte nonce. GCM is *authenticated*, so a wrong
   passphrase or any modification to the data (or its header) is detected and the operation is
   refused rather than returning garbage.

Container layout (big-endian; the header is authenticated as GCM associated data):

```
MAGIC "CRYPTID1" (8) | VERSION (1) | KDF_ID (1) | ITERATIONS (4) |
SALT_LEN (1) | SALT (16) | NONCE (12) | TAG (16) | CIPHERTEXT
```

All parameters needed to decrypt are in the header, so only the passphrase is secret, and the
iteration count can be raised in future versions without breaking old files.

`text` emits the container as Base64 so it can be pasted into a message. `zip` builds a standard
Zip archive in memory, then seals the whole archive with the same container.

## Deliberate choices and limits

- **Not compatible with the 2020 build.** That version derived a deterministic key *and* IV from
  an unsalted SHA-256 of the passphrase and used unauthenticated AES-CBC. Those are the
  weaknesses this rewrite exists to fix, so old ciphertext cannot (and should not) be read by it.
- **`.czip` is not a standard password-protected Zip.** It is a Zip archive wrapped in CryptID's
  authenticated container, produced and read only by CryptID. This keeps one vetted encryption
  path and avoids the legacy WinZip-AES zip dependency. If you need archives that 7-Zip/WinZip can
  open with a password, that can be added with a maintained AES-Zip library — open an issue.
- **Whole-file in memory.** `file` and `zip` load the input into memory to encrypt it in one
  authenticated pass. Fine for typical documents and projects; not intended for files larger than
  available RAM. (AES-GCM also has a per-key data limit far above that point.)
- **Password generation** uses a cryptographically secure RNG (`RandomNumberGenerator`), unlike
  the original's `System.Random`, and guarantees at least one character from each selected class.

## Project layout

```
CryptID.sln
src/CryptID/         console app (Program.cs, Crypto/, Cli/, Commands/)
tests/CryptID.Tests/ xUnit tests: round-trip, wrong-passphrase, tamper detection, generator
```

## License

CryptID is source-available under the [PolyForm Noncommercial License 1.0.0](https://polyformproject.org/licenses/noncommercial/1.0.0/): free to use, modify, and share for **noncommercial** purposes. **Commercial use requires a separate paid license** — contact sean@sparwol.com. See [LICENSE](LICENSE).
