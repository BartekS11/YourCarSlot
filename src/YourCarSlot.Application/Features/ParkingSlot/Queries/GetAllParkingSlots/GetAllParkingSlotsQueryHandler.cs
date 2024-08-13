using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

public sealed class GetAllParkingSlotsQuery
{
    public sealed record Command : IRequest<List<ParkingSlotDto>>;

    internal sealed class Handler(IParkingSlotRepository parkingSlotRepository) : IRequestHandler<Command, List<ParkingSlotDto>>
    {
        private readonly IParkingSlotRepository _parkingSlotRepository = parkingSlotRepository;

        public async Task<List<ParkingSlotDto>> Handle(Command request, CancellationToken cancellationToken)
        {
            var parkingSlotsTypes = await _parkingSlotRepository.GetAsync(cancellationToken);

            var data = new List<ParkingSlotDto>();
            foreach(var parkingSlot in parkingSlotsTypes)
            {
                var item = ParkingSlotMapper.Map(parkingSlot);
                data.Add(item);
            }

            return data;
        }
    }
}
