// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
namespace InfiniLore.Database.RepositoryPattern;

// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public interface IHasCountAsync {
    ValueTask<RepoResult<int>> TryCountAsync(CancellationToken ct = default);
}
