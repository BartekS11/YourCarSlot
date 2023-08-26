using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(YCSDatabaseContext context) : base(context)
        {
        }

        public async Task<Vehicle> GetByPlateNumberAsync(string plateNumber) 
            => await _context.Set<Vehicle>().FindAsync(plateNumber);
    }
}