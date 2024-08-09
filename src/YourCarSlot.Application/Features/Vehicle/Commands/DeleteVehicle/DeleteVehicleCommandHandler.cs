using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle;

public sealed class DeleteVehicleCommandHandler : IRequestHandler<DeleteVehicleCommand, Unit>
{
    private readonly IVehicleRepository _vehicleRepository;

    public DeleteVehicleCommandHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<Unit> Handle(DeleteVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicleToDelete = await _vehicleRepository.GetByPlateNumberAsync(request.PlateNumber, cancellationToken);

        await _vehicleRepository.DeleteAsync(vehicleToDelete!, cancellationToken);

        return Unit.Value;
    }
}