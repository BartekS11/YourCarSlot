using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IParkingSlotRepository : IGenericRepository<ParkingSlot>
    {
        Task<bool> IsParkingSlotUnique(Guid slotid);
    }
}