using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle
{
    public class UpdateVehicleCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string? PlateNumber { get; set; }
        public string MakeOfCar { get; set; }
    }
}