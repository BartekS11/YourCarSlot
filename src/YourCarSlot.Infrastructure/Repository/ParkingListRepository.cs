
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;
using YourCarSlot.Infrastructure.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class ParkingListRepository : GenericRepository<ParkingListRepository>, IParkingListRepository
    {
        public ParkingListRepository(YCSDatabaseContext context) : base(context)
        {
        }

        public Task AddCar(Car car, int slot)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(ParkingList entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ParkingList entity)
        {
            throw new NotImplementedException();
        }

        public Task<ParkingList> GetParkingListDetails()
        {
            throw new NotImplementedException();
        }

        public Task<List<ParkingList>> GetParkingListsDetails()
        {
            throw new NotImplementedException();
        }

        public Task<ParkingList> GetSlotDetails(ParkingListName name, Car car, ParkingSlots parkingSlot)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ParkingList entity)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<ParkingList>> IGenericRepository<ParkingList>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<ParkingList> IGenericRepository<ParkingList>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}