using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YourCarSlot.Identity.Configuration;

public sealed class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "546ff490-b5df-11ed-afa1-0242ac120002",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
        );
    }
}