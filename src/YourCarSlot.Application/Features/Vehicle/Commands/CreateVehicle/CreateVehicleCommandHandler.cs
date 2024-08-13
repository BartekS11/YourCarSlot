using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;

public sealed class CreateVehicleHandler
{
    public sealed record Command(string PlateNumber, string MakeOfCar) : IRequest<Guid>;

    internal sealed class Handler : IRequestHandler<Command, Guid>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public Handler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
        {
            var vehicleToCreate = VehicleMapper.Map(request);
            await _vehicleRepository.CreateAsync(vehicleToCreate, cancellationToken);

            return vehicleToCreate.Id;
        }
    }
}
