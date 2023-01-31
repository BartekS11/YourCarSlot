namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAsync();
        Task CreateAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}