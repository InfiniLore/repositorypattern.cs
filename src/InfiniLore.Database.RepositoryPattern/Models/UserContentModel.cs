// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfiniLore.Database.RepositoryPattern;

// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public class UserContentModel<TUser> : BasicContentModel, IHasOwner<TUser> where TUser : IdentityUser<Guid> {
    public virtual TUser Owner { get; set; } = null!;
    public Guid OwnerId { get; set; }
    
    /// <summary>
    ///     Gets or sets a value indicating whether the content is publicly readable.
    ///     When authorization validation is performed, this property overrides the user's access level
    ///     to always allow for read access if set to true.
    /// </summary>
    public bool IsPubliclyReadable { get; set; } = false;

    /// <summary>
    ///     Gets or sets a value indicating whether the content is discoverable through search features.
    ///     When set to false, you should only be able to find this resource by direct references.
    /// </summary>
    public bool IsDiscoverable { get; set; } = true;

    /// <summary>
    ///     Determines whether the content should be included in discoverability search results.
    /// </summary>
    [NotMapped] public bool IncludeInDiscoverSearch => IsPubliclyReadable && IsDiscoverable;
}
