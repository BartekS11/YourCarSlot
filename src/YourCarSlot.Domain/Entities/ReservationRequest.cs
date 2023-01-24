using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ReservationRequest : BaseEntity
    {
        public enum PartOfTheDay { AM, PM };
        public PartOfTheDay PartOfTheDayReservation { get; protected set; }
        public DateTime BookingRequestTime { get; protected set; }
        public User UserRequesting { get; protected set; }
        public ParkingList ParkingListRequesting { get; protected set; }
        public ParkingSlots ParkingSlotRequesting { get; protected set; }
        public bool Reserved { get; protected set; } = false;
        public ReservationRequest(DateTime bookingrequesttime,
                                  User userrequesting, ParkingList parkinglistrequesting,
                                  PartOfTheDay partoftheday, ParkingSlots parkingSlotRequesting)
        {
            Id = Guid.NewGuid();
            BookingRequestTime = bookingrequesttime;
            UserRequesting = userrequesting;
            ParkingListRequesting = parkinglistrequesting;
            PartOfTheDayReservation = partoftheday;
            Reserved = true;
            ParkingSlotRequesting = parkingSlotRequesting;
        }
    }
}