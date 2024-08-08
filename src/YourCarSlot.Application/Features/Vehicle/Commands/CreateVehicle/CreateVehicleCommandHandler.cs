using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;

public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IAppLogger<CreateVehicleCommandHandler> _logger;

    public CreateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<CreateVehicleCommandHandler> logger)
    {
        _mapper = mapper;
        _vehicleRepository = vehicleRepository;
        _logger = logger;
    }

    public async Task<Guid> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicleToCreate = _mapper.Map<Domain.Entities.Vehicle>(request);

        await _vehicleRepository.CreateAsync(vehicleToCreate);

        _logger.LogInformation("Vehicle added successfuly");

        return vehicleToCreate.Id;
    }
}