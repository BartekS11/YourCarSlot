using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        [Key]
        public string PlateNumber { get; set; }  = string.Empty;
        public string MakeOfCar { get; set; }  = string.Empty;
        public Localization CarLocalization { get; }
    }
}