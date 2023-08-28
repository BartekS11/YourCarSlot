using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle
{
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger<UpdateVehicleCommandHandler> _logger;

        public UpdateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<UpdateVehicleCommandHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _vehicleRepository = vehicleRepository ?? throw new ArgumentNullException(nameof(vehicleRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(UpdateVehicleCommand request, CancellationToken cancellationToken)
        {
            var vehicleToUpdate = _mapper.Map<Domain.Entities.Vehicle>(request);

            await _vehicleRepository.UpdateAsync(vehicleToUpdate);

            _logger.LogTraceInformation("Vehicle updated successfuly");

            return Unit.Value;
        }
    }
}