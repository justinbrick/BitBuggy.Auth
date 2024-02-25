namespace BitBuggy.Auth.Models;

public class ApplicationPermission
{
    /// <summary>
    /// The ClientId of the application that the permission is made for.
    /// </summary>
    public required Guid ClientId { get; set; }
    /// <summary>
    /// The unique identifier of any given permission.
    /// </summary>
    public Guid PermissionId { get; set; } = Guid.NewGuid();
    /// <summary>
    /// The string that represents the scope of the permission.
    /// </summary>
    public required string PermissionScope { get; set; }
    /// <summary>
    /// A simple description of what the permission is designed for.
    /// </summary>
    public required string PermissionDescription { get; set; }
}