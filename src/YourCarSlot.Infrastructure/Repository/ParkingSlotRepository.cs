using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        {
            return await _context.ParkingSlots.AnyAsync(q => q.Id == slotid);
        }
    }
}