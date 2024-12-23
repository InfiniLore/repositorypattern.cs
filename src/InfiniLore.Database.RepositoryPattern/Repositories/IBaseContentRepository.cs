// ---------------------------------------------------------------------------------------------------------------------
// Imports
// ---------------------------------------------------------------------------------------------------------------------
namespace InfiniLore.Database.RepositoryPattern;
// ---------------------------------------------------------------------------------------------------------------------
// Code
// ---------------------------------------------------------------------------------------------------------------------
public interface IBasicContentRepository<T> :
    IHasTryAddAsync<T>,
    IHasTryUpdateAsync<T>,
    IHasTryAddOrUpdateAsync<T>,
    IHasTryDeleteAsync<T>,
    IHasTryRemoveAsync<T>,
    IHasTryGetByIdAsync<T>,
    IHasTryGetAllAsync<T>,
    IHasTryGetByCriteriaAsync<T>,
    IHasCountAsync,
    IRepository
    where T : BasicContentModel;
