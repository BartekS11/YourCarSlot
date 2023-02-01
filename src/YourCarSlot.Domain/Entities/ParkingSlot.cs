using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingSlot : BaseEntity
    {
       private int _levelId { get; set; }
       private int _spotId { get; set; }
    }
}