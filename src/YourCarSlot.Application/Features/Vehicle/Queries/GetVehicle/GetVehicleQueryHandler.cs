using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Shared.Abstractions.Mediator.CommandHandling;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

public sealed class GetVehicleHandler
{
    public sealed record Command(Guid Id) : IYcsRequest<VehicleDto>;

    internal sealed class GetVehicleQueryHandler : IRequestHandler<Command, VehicleDto>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetVehicleQueryHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<VehicleDto> Handle(Command request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(request.Id, cancellationToken)
                ?? throw new NotFoundException("Vehicle cannot be found");

            var data = VehicleMapper.Map(vehicle);

            return data;
        }
    }
}

