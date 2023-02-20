using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.EF.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var userGuid = "36b99c90-b13d-11ed-afa1-0242ac120002";
            var userGuid1 = "4428bf00-b13d-11ed-afa1-0242ac120002";

            builder.HasData(
                new User
                {
                    Id = Guid.Parse(userGuid),
                    Email = "Wojciech@polo.pl",
                    Username = "DriftWojciech",
                    Password = "1234567",
                    Salt = "1",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = Guid.Parse(userGuid1),
                    Email = "Kubus@polo.pl",
                    Username = "pogczamp",
                    Password = "1234567",
                    Salt = "4",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}