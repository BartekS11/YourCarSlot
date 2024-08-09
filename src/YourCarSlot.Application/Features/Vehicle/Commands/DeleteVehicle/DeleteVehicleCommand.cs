using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle;

public sealed class DeleteVehicleCommand : IRequest<Unit>
{
    public string PlateNumber { get; init; } = default!;
}