using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

public sealed class GetAllParkingSlotsQueryHandler(IMapper mapper, IParkingSlotRepository parkingSlotRepository, IAppLogger<GetAllParkingSlotsQueryHandler> logger) : IRequestHandler<GetAllParkingSlotsQuery, List<ParkingSlotDto>>
{
    private readonly IMapper _mapper = mapper;
    private readonly IParkingSlotRepository _parkingSlotRepository = parkingSlotRepository;
    private readonly IAppLogger<GetAllParkingSlotsQueryHandler> _logger = logger;

    public async Task<List<ParkingSlotDto>> Handle(GetAllParkingSlotsQuery request, CancellationToken cancellationToken)
    {
        var parkingSlotsTypes = await _parkingSlotRepository.GetAsync(cancellationToken);

        var data = _mapper.Map<List<ParkingSlotDto>>(parkingSlotsTypes);
        _logger.LogInformation("All parking slots requests were retrieved successfuly");

        return data;
    }
}