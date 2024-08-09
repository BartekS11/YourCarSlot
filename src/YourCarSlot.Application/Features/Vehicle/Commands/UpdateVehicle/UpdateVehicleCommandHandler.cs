using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;

public sealed class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IVehicleRepository _vehicleRepository;

    public UpdateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository)
    {
        _mapper = mapper;
        _vehicleRepository = vehicleRepository;
    }

    public async Task<Unit> Handle(UpdateVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicleToUpdate = _mapper.Map<Domain.Entities.Vehicle>(request);

        await _vehicleRepository.UpdateAsync(vehicleToUpdate, cancellationToken);

        return Unit.Value;
    }
}