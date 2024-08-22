using YourCarSlot.Api.Middleware;
using YourCarSlot.Application;
using YourCarSlot.Identity;
using YourCarSlot.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseDefaultServiceProvider((ctx, options) =>
{
    options.ValidateOnBuild = ctx.HostingEnvironment.IsDevelopment();
    options.ValidateScopes = ctx.HostingEnvironment.IsDevelopment();
});

builder.Services.AddHealthChecks();
builder.Services.AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddIdentityServices(builder.Configuration)
    .AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen(c => 
        { 
            c.CustomSchemaIds(type => type.ToString());
        });

var app = builder.Build();

app.MapHealthChecks("/healthchecks");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");   
    });
}

app
    .UseMiddleware<ExceptionMiddleware>()
    .UseHttpsRedirection()
    .UseCors("all")
    .UseAuthentication()
    .UseAuthorization();

app.MapControllers();
app.Run();
