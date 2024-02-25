using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BitBuggy.Auth.Models;

public class ApplicationClient
{
    public required Guid ClientId { get; set; }
    public required Uri ApplicationUrl { get; set; }
    public required string ApplicationName { get; set; }
    public required string ApplicationDescription { get; set; }
    public required string HashedApplicationSecret { get; set; }

    public static string CreateApplicationSecret()
    {
        const string identifier = "bbg";
        string secretString = RandomNumberGenerator.GetHexString(1024 / 32);
        return $"{identifier}-{secretString}";
    }
    public static string HashApplicationSecret(string applicationSecret)
    {
        return Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: applicationSecret,
            salt: [], // In this case, since the application secret is generated through cryptographically secure means, we don't need a salt.
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 200000,
            numBytesRequested: 256 / 8
        ));
    }
}