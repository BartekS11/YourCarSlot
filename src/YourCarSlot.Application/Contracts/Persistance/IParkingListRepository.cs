using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Application.Contracts.Persistance
{
    public interface IParkingListRepository : IGenericRepository<ParkingList>
    {
        Task<ParkingList> GetParkingListDetails();

        Task<List<ParkingList>> GetParkingListsDetails();

        Task<ParkingList> GetSlotDetails(ParkingListName name, Car car, ParkingSlots parkingSlot);

        Task AddCar(Car car, int slot);
    }
}