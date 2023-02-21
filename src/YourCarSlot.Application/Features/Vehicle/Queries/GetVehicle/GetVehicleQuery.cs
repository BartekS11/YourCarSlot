using MediatR;

namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle
{
    public record GetVehicleQuery(Guid Id) : IRequest<VehicleDto>;
}