// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;

namespace InfiniLore.Database.RepositoryPattern;
// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public interface IUserContentRepository<TModel, TUser> :
    IBasicContentRepository<TModel>,
    IHasTryGetByUserAsync<TModel, TUser>
    where TModel : UserContentModel<TUser> 
    where TUser : IdentityUser<Guid>;
