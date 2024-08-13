using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetAllVehicles;

internal sealed class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQuery, List<VehicleDto>>
{
    private readonly IVehicleRepository _vehicleRepository;

    public GetAllVehiclesQueryHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<List<VehicleDto>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
    {
        var allVehicles = await _vehicleRepository.GetAsync(cancellationToken);

        var data = new List<VehicleDto>();

        foreach(var vehicle in allVehicles)
        {
            var mappedVehicle = VehicleMapper.Map(vehicle);
            data.Add(mappedVehicle);
        }

        return data;
    }
}
