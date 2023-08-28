using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle
{
    public class DeleteVehicleCommandHandler : IRequestHandler<DeleteVehicleCommand, Unit>
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger<DeleteVehicleCommandHandler> _logger;

        public DeleteVehicleCommandHandler(IVehicleRepository vehicleRepository, IAppLogger<DeleteVehicleCommandHandler> logger)
        {
            _vehicleRepository = vehicleRepository ?? throw new ArgumentNullException(nameof(vehicleRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(DeleteVehicleCommand request, CancellationToken cancellationToken)
        {
            var vehicleToDelete = await _vehicleRepository.GetByPlateNumberAsync(request.PlateNumber);

            await _vehicleRepository.DeleteAsync(vehicleToDelete);

            _logger.LogTraceInformation("Vehicle deleted successfuly");

            return Unit.Value;
        }
    }
}