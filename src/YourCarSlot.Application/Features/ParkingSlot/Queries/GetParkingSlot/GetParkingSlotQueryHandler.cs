using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetParkingSlot
{
    public class GetParkingSlotQueryHandler : IRequestHandler<GetParkingSlotQuery, ParkingSlotDto>
    {
        private readonly IMapper _mapper;
        private readonly IParkingSlotRepository _parkingSlotRepository;
        private readonly IAppLogger<GetParkingSlotQueryHandler> _logger;

        public GetParkingSlotQueryHandler(IMapper mapper, IParkingSlotRepository parkingSlotRepository, IAppLogger<GetParkingSlotQueryHandler> logger)
        { 
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _parkingSlotRepository = parkingSlotRepository ?? throw new ArgumentNullException(nameof(parkingSlotRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ParkingSlotDto> Handle(GetParkingSlotQuery request, CancellationToken cancellationToken)
        {
            var parkingSlot = await _parkingSlotRepository.GetByIdAsync(request.Id);

            var data = _mapper.Map<ParkingSlotDto>(parkingSlot);
            _logger.LogInformation("Parking slot received successfuly");

            return data;
        }
    }
}
