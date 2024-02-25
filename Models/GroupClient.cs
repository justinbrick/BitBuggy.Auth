namespace BitBuggy.Auth.Models;

public class GroupClient
{
    public required Guid ClientId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}