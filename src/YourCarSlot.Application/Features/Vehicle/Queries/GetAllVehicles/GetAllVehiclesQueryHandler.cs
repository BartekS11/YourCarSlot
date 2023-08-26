using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetAllVehicles
{
    public class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQuery, List<VehicleDto>>
    {
        private readonly IMapper _mapper;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger<GetAllVehiclesQueryHandler> _logger;

        public GetAllVehiclesQueryHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<GetAllVehiclesQueryHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _vehicleRepository = vehicleRepository ?? throw new ArgumentNullException(nameof(vehicleRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<VehicleDto>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
        {
            var allVehicles = await _vehicleRepository.GetAsync();
            
            var data = _mapper.Map<List<VehicleDto>>(allVehicles);
            _logger.LogInformation("All Vehicles info retrieved successfuly");
            return data;
        }
    }
}