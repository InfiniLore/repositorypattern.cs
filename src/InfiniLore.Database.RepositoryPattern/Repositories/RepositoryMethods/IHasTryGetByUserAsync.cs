// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;

namespace InfiniLore.Database.RepositoryPattern;
// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
/// <summary>
/// Provides asynchronous methods to retrieve user-specific data stored in the repository.
/// </summary>
/// <typeparam name="TModel">The type of user content model used in the repository.</typeparam>
/// <typeparam name="TUser">The type of user associated with the content model, typically inheriting from <see cref="IdentityUser{TKey}" />.</typeparam>
public interface IHasTryGetByUserAsync<TModel, TUser>
    where TModel : UserContentModel<TUser>
    where TUser : IdentityUser<Guid> {
    /// <summary>
    /// Attempts to retrieve user content associated with a specified user identifier.
    /// </summary>
    /// <typeparam name="TModel">The type of user content to be retrieved.</typeparam>
    /// <param name="userId">The user identifier used to locate the associated user content.</param>
    /// <param name="ct">Optional. A cancellation token that can be used to cancel the operation.</param>
    /// <returns>
    /// A <see cref="ValueTask{TResult}" /> that represents the asynchronous operation. The task result contains a
    /// <see cref="RepoResult{T}" />
    /// indicating the success or failure of the retrieval operation. On success, it contains an array of the requested
    /// user content.
    /// </returns>
    ValueTask<RepoResult<TModel[]>> TryGetByUserAsync(Guid userId, CancellationToken ct = default);

    /// <summary>
    /// Asynchronously attempts to retrieve user-specific content associated with a specified user identifier.
    /// </summary>
    /// <typeparam name="TModel">The type of the user content to retrieve.</typeparam>
    /// <typeparam name="TUser">The type of the user entity associated with the content.</typeparam>
    /// <param name="userId">
    /// The unique identifier of the user whose content is to be retrieved.
    /// </param>
    /// <param name="pageInfo">
    /// Specifies the paging information, including the page number and page size, for the query.
    /// </param>
    /// <param name="ct">
    /// An optional <see cref="CancellationToken" /> to monitor for cancellation requests while completing the operation.
    /// </param>
    /// <returns>
    /// A <see cref="ValueTask{TResult}" /> representing an asynchronous operation with a result of type
    /// <see cref="RepoResult{T}" /> containing an array of user-specific content.
    /// </returns>
    ValueTask<RepoResult<TModel[]>> TryGetByUserAsync(Guid userId, PaginationInfo pageInfo, CancellationToken ct = default);
}
