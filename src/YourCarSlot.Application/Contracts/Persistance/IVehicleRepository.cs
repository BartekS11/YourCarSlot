using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Contracts.Persistance;

public interface IVehicleRepository : IGenericRepository<Vehicle>
{
    public Task<Vehicle?> GetByPlateNumberAsync(string plateNumber, CancellationToken cancellationToken = default);
}