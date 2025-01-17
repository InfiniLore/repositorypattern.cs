// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;

namespace InfiniLore.Database.RepositoryPattern;
// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public interface IHasOwner<TUser> where TUser : IdentityUser<Guid> {
    public TUser Owner { get; set; }
    public Guid OwnerId { get; set; }
}
