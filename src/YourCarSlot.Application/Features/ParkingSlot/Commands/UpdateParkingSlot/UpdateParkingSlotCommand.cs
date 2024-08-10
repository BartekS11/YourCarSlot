using MediatR;

namespace YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot;

public sealed class UpdateParkingSlotCommand : IRequest<Unit>
{
    public Guid Id { get; init; }
    public int? ParkingspotId { get; init; }   
}