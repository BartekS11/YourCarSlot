using YourCarSlot.Api.Middleware;
using YourCarSlot.Application;
using YourCarSlot.Identity;
using YourCarSlot.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseDefaultServiceProvider((ctx, options) => {
    options.ValidateOnBuild = ctx.HostingEnvironment.IsDevelopment();
    options.ValidateScopes = ctx.HostingEnvironment.IsDevelopment();
});

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddCors( options => {
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("all");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
