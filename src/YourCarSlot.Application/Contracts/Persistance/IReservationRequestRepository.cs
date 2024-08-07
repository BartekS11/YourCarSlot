using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Contracts.Persistance;

public interface IReservationRequestRepository : IGenericRepository<ReservationRequest>
{
    public Task<ReservationRequest> GetReservationRequestWithDetails(Guid id, CancellationToken cancellationToken);
}