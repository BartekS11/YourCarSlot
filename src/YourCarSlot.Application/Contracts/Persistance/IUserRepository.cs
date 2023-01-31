using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserDetails(Guid id);

    }
}