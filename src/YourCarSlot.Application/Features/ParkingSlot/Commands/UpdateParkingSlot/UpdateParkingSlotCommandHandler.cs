using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot;

public sealed class UpdateParkingSlotCommand
{
    public sealed record Command(Guid Id, int? ParkingspotId) : IRequest<Unit>;

    internal sealed class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IParkingSlotRepository _parkingSlotRepository;

        public Handler(IParkingSlotRepository parkingSlotRepository)
        {
            _parkingSlotRepository = parkingSlotRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var parkingSlot = new Domain.Entities.ParkingSlot
            {
                Id = request.Id,
                ParkingspotId = request.ParkingspotId
            };

            await _parkingSlotRepository.UpdateAsync(parkingSlot, cancellationToken);

            return Unit.Value;
        }
    }
}


