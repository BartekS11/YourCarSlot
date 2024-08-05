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
            this._mapper = mapper;
            this._vehicleRepository = vehicleRepository;
            this._logger = logger;
        }

        public async Task<List<VehicleDto>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
        {
            var allVehicles = await _vehicleRepository.GetAsync(cancellationToken);
            
            var data = _mapper.Map<List<VehicleDto>>(allVehicles);

            return data;
        }
    }
}