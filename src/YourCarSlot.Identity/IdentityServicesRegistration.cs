using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using YourCarSlot.Application.Identity;
using YourCarSlot.Application.Models.Identity;
using YourCarSlot.Identity.DbContext;
using YourCarSlot.Identity.Models;
using YourCarSlot.Identity.Services;

namespace YourCarSlot.Identity;

public static class IdentityServicesRegistration
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
        services.AddDbContext<YCSIdentityDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnections"));
        });

        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<YCSIdentityDbContext>()
            .AddDefaultTokenProviders();

        services.AddTransient<IAuthService, AuthServices>();
        services.AddTransient<IUserService, UserService>();

        services.AddAuthentication(options => 
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }
        ).AddJwtBearer(o => 
        {
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                ValidIssuer = configuration["JwtSettings:Issuer"],
                ValidAudience = configuration["JwtSettings:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!))
            };
        });
        return services;
    }
}