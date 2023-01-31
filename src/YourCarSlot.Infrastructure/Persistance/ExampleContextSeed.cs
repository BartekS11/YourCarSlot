using MongoDB.Driver;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;

namespace Example.Infrastructure.Persistence
{
    public class ExampleContextSeed
    {
        public static void SeedData(IMongoCollection<ReservationRequest> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<ReservationRequest> GetPreconfiguredProducts()
        {
            return new List<ReservationRequest>()
            {
                new ReservationRequest(
                    DateTime.UtcNow, 
                    new User("Wojcieh@mfdsak.pl", "dsa", "rteww", "setngwoetngoi"), 
                    new ParkingList(Guid.NewGuid(), new ParkingListName("1"), new Localization("dsa", "dsad", "vv")),
                    ReservationRequest.PartOfTheDay.AM, 
                    new YourCarSlot.Domain.ValueObjects.ParkingSlots(10)
                ),

                new ReservationRequest(
                    DateTime.UtcNow, 
                    new User("idziemyPoMilion@mfdsak.pl", "c", "c", "cxvczxvz vz"), 
                    new ParkingList(Guid.NewGuid(), new ParkingListName("1"), new Localization("dsa", "dsad", "vv")), 
                    ReservationRequest.PartOfTheDay.AM, 
                    new YourCarSlot.Domain.ValueObjects.ParkingSlots(10)
                )
            };
        }
    }
}