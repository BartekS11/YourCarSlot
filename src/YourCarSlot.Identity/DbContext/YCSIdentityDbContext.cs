using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YourCarSlot.Identity.Models;

namespace YourCarSlot.Identity.DbContext
{
    public class YCSIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public YCSIdentityDbContext(DbContextOptions<YCSIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(YCSIdentityDbContext).Assembly);
        }
    }
}