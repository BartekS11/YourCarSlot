using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository;

public sealed class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(YCSDatabaseContext context) : base(context)
    {
    }
}
