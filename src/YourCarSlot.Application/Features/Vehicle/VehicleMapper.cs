using YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

namespace YourCarSlot.Application.Features.Vehicle;

internal static class VehicleMapper
{
    internal static VehicleDto Map(Domain.Entities.Vehicle vehicle)
        => new()
        {
            Id = vehicle.Id,
            MakeOfCar = vehicle.MakeOfCar,
            PlateNumber = vehicle.PlateNumber!,
        };

    internal static Domain.Entities.Vehicle Map(UpdateVehicleHandler.Command command)
        => new()
        {
            Id = command.Id,
            MakeOfCar = command.MakeOfCar,
            PlateNumber = command.PlateNumber
        };

    internal static Domain.Entities.Vehicle Map(CreateVehicleHandler.Command command)
        => new()
        {
            MakeOfCar = command.MakeOfCar,
            PlateNumber = command.PlateNumber
        };
}
