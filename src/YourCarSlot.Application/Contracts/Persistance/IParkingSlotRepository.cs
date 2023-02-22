using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IParkingSlotRepository : IGenericRepository<ParkingSlot>
    {
        Task<bool> IsParkingSlotUnique(Guid slotid);
    }
}