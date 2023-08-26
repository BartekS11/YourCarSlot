using Microsoft.EntityFrameworkCore;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class ParkingSlotRepository : GenericRepository<ParkingSlot>, IParkingSlotRepository
    {
        public ParkingSlotRepository(YCSDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsParkingSlotUnique(Guid slotid) 
            => await _context.ParkingSlot.AnyAsync(q => q.Id == slotid);
    }
}