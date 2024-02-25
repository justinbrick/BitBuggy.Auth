namespace BitBuggy.Auth.Models;

// A class that represents the registration of a client.
// When you create a user, application, or group, you will need to register the client with the BitBuggy.Auth service.
public class ClientRegistration
{
    /// <summary>
    /// The unique identifier for the client.
    /// </summary>
    public Guid ClientId { get; set; } = Guid.NewGuid();
    /// <summary>
    /// The date that the client was created.
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}