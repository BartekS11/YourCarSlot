using Microsoft.EntityFrameworkCore;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<UserRepository>, IUserRepository
    {
        public UserRepository(YCSDatabaseContext context) : base(context)
        {
            
        }

        public Task CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserDetails(Guid id)
        {
            var user = await _context.Users
                .Include(q => q.CarOwned)
                .Include(q => q.DateModified)
                .FirstOrDefaultAsync(q => q.Id == id);           
            return user;
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<User>> IGenericRepository<User>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<User> IGenericRepository<User>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}