using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User("Wojciech@email.com", "Wojciech", "12345678", "42379843274289")
            );

            builder.Property(p => p.FullName)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}