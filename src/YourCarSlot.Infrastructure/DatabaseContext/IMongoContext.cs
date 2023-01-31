using MongoDB.Driver;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.DatabaseContext
{
    public interface IMongoContext
    {
        IMongoCollection<ReservationRequest> Parking { get; }
        IMongoDatabase Database { get; }
    }
}