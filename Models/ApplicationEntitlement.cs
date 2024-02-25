namespace BitBuggy.Auth.Models;

public class ApplicationEntitlement
{
    /// <summary>
    /// This is the ID of the client that the entitlement has been assigned to.
    /// This can be a user, application, or group.
    /// </summary>
    public required Guid ClientId { get; set; }
    /// <summary>
    /// This is the ID of the permission that the client has been assigned.
    /// This maps to ApplicationPermission::PermissionId.
    /// The reasoning behind this choice is that, instead of using a permission string, 
    /// we are able to freely change the permission string without having to update the entitlements.
    /// </summary>
    public required Guid PermissionId { get; set; }
}