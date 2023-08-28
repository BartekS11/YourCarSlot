using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle
{
    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger<CreateVehicleCommandHandler> _logger;

        public CreateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<CreateVehicleCommandHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _vehicleRepository = vehicleRepository ?? throw new ArgumentNullException(nameof(vehicleRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Guid> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            var vehicleToCreate = _mapper.Map<Domain.Entities.Vehicle>(request);

            await _vehicleRepository.CreateAsync(vehicleToCreate);

            _logger.LogTraceInformation("Vehicle created successfuly");

            return vehicleToCreate.Id;
        }
    }
}