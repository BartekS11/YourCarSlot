using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle
{
    public class GetVehicleQueryHandler : IRequestHandler<GetVehicleQuery, VehicleDto>
    {
        private readonly IMapper _mapper;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger<GetVehicleQueryHandler> _logger;

        public GetVehicleQueryHandler(IMapper mapper, IVehicleRepository vehicleRepository, IAppLogger<GetVehicleQueryHandler> logger)
        {
            this._mapper = mapper;
            this._vehicleRepository = vehicleRepository;
            this._logger = logger;
        }

        public async Task<VehicleDto> Handle(GetVehicleQuery request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(request.Id);

            var data = _mapper.Map<VehicleDto>(vehicle);

            return data;
        }
    }
}