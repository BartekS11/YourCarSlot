using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace YourCarSlot.Identity.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                    UserId = "532facd9-f5a8-4e7b-913b-2ffa16412c37"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "546ff490-b5df-11ed-afa1-0242ac120002",
                    UserId = "532facd9-f5a8-4e7b-913b-2ffa16412c37"
                }
            );
        }
    }
}