// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------=
namespace InfiniLore.Database.RepositoryPattern;
// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
/// <summary>
///     Represents a contract for adding or updating a model in an asynchronous manner.
/// </summary>
/// <typeparam name="T">The type of the model, which must inherit from BasicContentModel.</typeparam>
public interface IHasTryAddOrUpdateAsync<in T> where T : BasicContentModel {
    /// <summary>
    ///     Attempts to add or update the specified model asynchronously in the repository.
    /// </summary>
    /// <typeparam name="T">The type of the model, which must inherit from <see cref="BasicContentModel" />.</typeparam>
    /// <param name="model">The model instance to be added or updated in the repository.</param>
    /// <param name="ct">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns>
    ///     A <see cref="ValueTask{RepoResult}" /> representing the result of the operation.
    ///     The result indicates success or contains an error message on failure.
    /// </returns>
    ValueTask<RepoResult> TryAddOrUpdateAsync(T model, CancellationToken ct = default);

    /// <summary>
    ///     Attempts to add or update a range of models in the repository asynchronously.
    /// </summary>
    /// <typeparam name="T">The type of models, which must derive from <see cref="BasicContentModel" />.</typeparam>
    /// <param name="models">An enumerable collection of models to add or update in the repository.</param>
    /// <param name="ct">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>
    ///     A <see cref="ValueTask{RepoResult}" /> representing the result of the operation, which indicates success or
    ///     failure.
    /// </returns>
    ValueTask<RepoResult> TryAddOrUpdateRangeAsync(IEnumerable<T> models, CancellationToken ct = default);
}
