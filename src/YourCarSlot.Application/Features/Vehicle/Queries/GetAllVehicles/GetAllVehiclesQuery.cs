using MediatR;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetAllVehicles;

public record GetAllVehiclesQuery : IRequest<List<VehicleDto>>;