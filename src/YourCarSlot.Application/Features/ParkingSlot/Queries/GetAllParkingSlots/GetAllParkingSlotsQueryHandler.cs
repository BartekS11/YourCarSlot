using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots
{
    public class GetAllParkingSlotsQueryHandler : IRequestHandler<GetAllParkingSlotsQuery, List<ParkingSlotDto>>
    {
        private readonly IMapper _mapper;
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IAppLogger<GetAllParkingSlotsQueryHandler> _logger;

        public GetAllParkingSlotsQueryHandler(IMapper mapper, IParkingSlotRepository parkingSlotRepository, IAppLogger<GetAllParkingSlotsQueryHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _parkingSlotRepository = parkingSlotRepository ?? throw new ArgumentNullException(nameof(parkingSlotRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<ParkingSlotDto>> Handle(GetAllParkingSlotsQuery request, CancellationToken cancellationToken)
        {
            var parkingSlotsTypes = await _parkingSlotRepository.GetAsync();

            var data = _mapper.Map<List<ParkingSlotDto>>(parkingSlotsTypes);
            _logger.LogInformation("All parking slots requests were retrieved successfuly");

            return data;
        }
    }
}