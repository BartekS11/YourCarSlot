using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

internal sealed class GetVehicleQueryHandler : IRequestHandler<GetVehicleQuery, VehicleDto>
{
    private readonly IVehicleRepository _vehicleRepository;

    public GetVehicleQueryHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<VehicleDto> Handle(GetVehicleQuery request, CancellationToken cancellationToken)
    {
        var vehicle = await _vehicleRepository.GetByIdAsync(request.Id, cancellationToken)
            ?? throw new NotFoundException("Vehicle cannot be found");

        var data = VehicleMapper.Map(vehicle);

        return data;
    }
}