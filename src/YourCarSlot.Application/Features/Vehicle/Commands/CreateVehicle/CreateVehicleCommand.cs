using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;

public class CreateVehicleCommand : IRequest<Guid>
{
    public string? PlateNumber { get; set; }
    public string MakeOfCar { get; set; }  = string.Empty;
    // public Localization CarLocalization { get; set; }
}