using Microsoft.EntityFrameworkCore;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.EF.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Vehicle> builder)
        {
            var guid1 = "0a417db6-b1f3-11ed-afa1-0242ac120002";
            builder.HasData(
                new Vehicle
                {
                   Id = Guid.Parse(guid1),
                   MakeOfCar = "bmw",
                   PlateNumber = "23233-33"
                }
            );
        }
    }
}