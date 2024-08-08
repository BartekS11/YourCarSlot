using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository;

public sealed class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
{
    public VehicleRepository(YCSDatabaseContext context) : base(context)
    {
    }

    public async Task<Vehicle?> GetByPlateNumberAsync(string plateNumber, CancellationToken cancellationToken)
    {
        return await _context.Set<Vehicle>()
            .FindAsync([plateNumber], cancellationToken: cancellationToken);
    }
}