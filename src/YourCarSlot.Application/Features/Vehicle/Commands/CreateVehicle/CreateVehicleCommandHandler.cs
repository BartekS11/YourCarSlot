using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;

public sealed class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IVehicleRepository _vehicleRepository;

    public CreateVehicleCommandHandler(IMapper mapper, IVehicleRepository vehicleRepository)
    {
        _mapper = mapper;
        _vehicleRepository = vehicleRepository;
    }

    public async Task<Guid> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
    {
        var vehicleToCreate = _mapper.Map<Domain.Entities.Vehicle>(request);

        await _vehicleRepository.CreateAsync(vehicleToCreate, cancellationToken);

        return vehicleToCreate.Id;
    }
}