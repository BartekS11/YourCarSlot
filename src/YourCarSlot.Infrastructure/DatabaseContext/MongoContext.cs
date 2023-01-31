using Example.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.DatabaseContext
{
    public class MongoContext : IMongoContext
    {

        public IMongoCollection<ReservationRequest> Parking { get; } 

        public IMongoDatabase Database { get; }

        
        public MongoContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("mongo:connectionString"));
            Database = client.GetDatabase(configuration.GetValue<string>("mongo:database"));
            Parking = Database.GetCollection<ReservationRequest>(configuration.GetValue<string>("mongo:CollectionName"));
            ExampleContextSeed.SeedData(Parking); 
        }
    }
}