using System.ComponentModel.DataAnnotations;
using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingSlot : BaseEntity
    {
        [Key]
        public int? ParkingspotId { get; set; }
        public int _levelId { get; set; }
        public ParkingSlot()
        {

        }
    }
}