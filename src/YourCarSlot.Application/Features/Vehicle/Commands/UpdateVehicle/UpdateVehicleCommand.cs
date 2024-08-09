using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;

public sealed class UpdateVehicleCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string? PlateNumber { get; set; }
    public string MakeOfCar { get; set; } = default!;
    // public Localization CarLocalization { get; set; }
}