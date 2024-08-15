namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

public sealed class VehicleDto
{
    public Guid Id { get; init; }
    public string MakeOfCar { get; init; } = string.Empty;
    public string PlateNumber { get; init; } = string.Empty;
}
