using MediatR;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;

public sealed class UpdateReservationCommand : IRequest<Unit>
{
    public Guid Id { get; init; }
    public int ParkingSlotRequesting { get; init; }
    public Guid UserRequestingId { get; init; }
    public PartOfTheDay PartOfTheDayReservation { get; init; }
    public DateTime BookingRequestTime { get; init; }
    public string PlateNumber { get; init; } = string.Empty;
}