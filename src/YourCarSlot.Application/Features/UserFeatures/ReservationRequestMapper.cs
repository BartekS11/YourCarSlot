using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Features.UserFeatures;

public static class ReservationRequestMapper
{
    public static ReservationRequestDto Map(ReservationRequest request)
        => new()
        {
            Id = request.Id,
            CreatedAt = request.CreatedAt,
            DateModified = request.DateModified,
            ParkingSlotRequesting = request.ParkingspotId,
            PlateNumber = request.PlateNumber!,
            Reserved = request.Reserved,
            UserRequestingId = request.UserRequestingId
        };
}