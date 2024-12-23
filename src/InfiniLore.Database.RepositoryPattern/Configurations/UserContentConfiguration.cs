// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfiniLore.Database.RepositoryPattern;

// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public class UserContentConfiguration<TModel, TUser> : BasicContentConfiguration<TModel>
    where TModel : UserContentModel<TUser>
    where TUser : IdentityUser<Guid>
{
    public override void Configure(EntityTypeBuilder<TModel> builder) {
        base.Configure(builder);// Call BasicContentModelConfiguration

        // Index on IsPublic and OwnerId to allow for fast filtering of public content by user
        builder.HasIndex(x => new {
            x.Id, x.OwnerId,
            IsPublic = x.IsPubliclyReadable
        });
    }
}
