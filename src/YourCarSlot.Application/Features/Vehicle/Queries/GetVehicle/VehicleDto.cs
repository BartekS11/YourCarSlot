namespace YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle
{
    public class VehicleDto
    {
        public Guid Id { get; set; }
        public string MakeOfCar { get; set; }  = string.Empty;
        public string PlateNumber { get; set; }  = string.Empty;
    }
}