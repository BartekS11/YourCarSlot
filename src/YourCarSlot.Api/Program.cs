using MongoDB.Driver;
using YourCarSlot.Application;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Infrastructure;
using YourCarSlot.Infrastructure.Repository;
using YourCarSlot.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDbSettings)));

// builder.Services.AddSingleton<IMongoClient>(s => 
//     new MongoClient(builder.Configuration.GetValue<string>("mongo:connectionString")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// Add services from diffrent layers
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddCors(options => {
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
