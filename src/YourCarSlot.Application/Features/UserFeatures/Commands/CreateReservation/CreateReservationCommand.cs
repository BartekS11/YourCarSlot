using MediatR;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;

public sealed class CreateReservationCommand : IRequest<Guid>
{
    public PartOfTheDay PartOfTheDayReservation { get; init; }
    public DateTime BookingRequestTime { get; init; }
    public Guid UserRequestingId { get; init; }
    public int ParkingSlotRequesting { get; init; }
    public string PlateNumber { get; init; } = string.Empty;
}