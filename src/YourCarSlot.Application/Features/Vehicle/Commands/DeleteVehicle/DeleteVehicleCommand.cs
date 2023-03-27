using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle
{
    public class DeleteVehicleCommand : IRequest<Unit>
    {
        public string PlateNumber { get; set; } = null!;
    }
}