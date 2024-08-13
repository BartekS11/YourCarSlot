using YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.Features.UserFeatures;

internal static class ReservationRequestMapper
{
    internal static ReservationRequestDto Map(ReservationRequest request)
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

    internal static ReservationRequest Map(CreateReservationHandler.Command command) 
        => new()
        {
            PartOfTheDayReservation = command.PartOfTheDayReservation,
            BookingRequestTime = command.BookingRequestTime,
            UserRequestingId = command.UserRequestingId,
            ParkingspotId = command.ParkingSlotRequesting,
            PlateNumber = command.PlateNumber
        };

    internal static ReservationRequest Map(UpdateReservationHandler.Command command) 
        => new()
        {
            Id = command.Id,
            ParkingspotId = command.ParkingSlotRequesting,
            UserRequestingId = command.UserRequestingId,
            PartOfTheDayReservation = command.PartOfTheDayReservation,
            BookingRequestTime = command.BookingRequestTime,
            PlateNumber = command.PlateNumber
        };
}