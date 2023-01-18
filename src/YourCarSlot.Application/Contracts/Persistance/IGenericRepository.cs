using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync();
        Task<T> CreateAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}