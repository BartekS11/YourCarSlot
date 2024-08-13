using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;

public sealed class UpdateVehicleHandler
{
    public sealed record Command(Guid Id, string PlateNumber, string MakeOfCar) : IRequest<Unit>;

    internal sealed class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public Handler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var vehicleToUpdate = VehicleMapper.Map(request);

            await _vehicleRepository.UpdateAsync(vehicleToUpdate, cancellationToken);

            return Unit.Value;
        }
    }
}

