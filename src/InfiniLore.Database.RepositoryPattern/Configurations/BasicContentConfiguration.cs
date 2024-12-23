// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfiniLore.Database.RepositoryPattern;

// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public class BasicContentConfiguration<T> : IEntityTypeConfiguration<T> where T : BasicContentModel {
    public virtual void Configure(EntityTypeBuilder<T> builder) {
        HasSoftDeleteAsQueryFilter(builder);
        HasUniqueIdAsKey(builder);
    }

    private static void HasSoftDeleteAsQueryFilter(EntityTypeBuilder<T> builder) {
        builder.HasQueryFilter(model => model.SoftDeleteDate == null);
    }

    private static void HasUniqueIdAsKey(EntityTypeBuilder<T> builder) {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
    }
}
