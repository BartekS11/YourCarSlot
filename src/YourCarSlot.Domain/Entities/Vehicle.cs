using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string MakeOfCar { get; }  = string.Empty;
        public string PlateNumber { get; }  = string.Empty;
        public Localization CarLocalization { get; }
    }
}