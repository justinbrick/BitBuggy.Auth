namespace BitBuggy.Auth.Models;

public class User
{
    /// <summary>
    /// The unique identifier for the user.
    /// This will be used in conjunction with OAuth2 to identify the user.
    /// </summary>
    public Guid ClientId { get; set; } = Guid.NewGuid();
    public required string Email { get; set; }
    public bool ApplicationAccount { get; set; } = false;
}