using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;

public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IAppLogger<UpdateVehicleCommandHandler> _logger;

    public UpdateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<UpdateVehicleCommandHandler> logger)
    {
        _mapper = mapper;
        _vehicleRepository = vehicleRepository;
        _logger = logger;
    }

    public async Task<Unit> Handle(UpdateVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicleToUpdate = _mapper.Map<Domain.Entities.Vehicle>(request);

        await _vehicleRepository.UpdateAsync(vehicleToUpdate);

        return Unit.Value;
    }
}