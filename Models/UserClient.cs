namespace BitBuggy.Auth.Models;

public class UserClient
{
    public required Guid ClientId { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

}