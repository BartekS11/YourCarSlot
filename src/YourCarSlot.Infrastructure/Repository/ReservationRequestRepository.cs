using Microsoft.EntityFrameworkCore;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository;

public sealed class ReservationRequestRepository : GenericRepository<ReservationRequest>, IReservationRequestRepository
{
    public ReservationRequestRepository(YCSDatabaseContext context) : base(context)
    {
    }

    public async Task<ReservationRequest> GetReservationRequestWithDetails(Guid id, CancellationToken cancellationToken)
    {
        var reservationRequest = await _context.ReservationRequest
            .Select(q => new ReservationRequest 
            {
                Id = q.Id,
                BookingRequestTime = q.BookingRequestTime,
                CreatedAt = q.CreatedAt,
                DateModified = q.DateModified,
                ParkingSlot = q.ParkingSlot,
                ParkingspotId = q.ParkingspotId,
                PartOfTheDayReservation = q.PartOfTheDayReservation,
                Reserved = q.Reserved,
                User = q.User,
                UserRequestingId = q.UserRequestingId,
                Vehicle = q.Vehicle,
                PlateNumber = q.PlateNumber
            })
            .FirstOrDefaultAsync(q => q.Id == id, cancellationToken);

        return reservationRequest!;
    }
}