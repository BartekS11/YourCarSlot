using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ReservationRequest : BaseEntity
    {
        public enum PartOfTheDay { AM, PM };
        public PartOfTheDay PartOfTheDayReservation { get; protected set; }
        public DateTime BookingRequestTime { get; protected set; }
        public User UserRequesting { get;  set; }
        public int ParkingSlotRequesting { get; protected set; }
        public bool Reserved { get; protected set; } = false;
        public string PlateNumber { get; }  = string.Empty;
        public ReservationRequest(DateTime bookingrequesttime,
                                  User userrequesting,
                                  PartOfTheDay partoftheday, int parkingSlotRequesting)
        {
            Id = Guid.NewGuid();
            BookingRequestTime = bookingrequesttime;
            UserRequesting = userrequesting;
            PartOfTheDayReservation = partoftheday;
            Reserved = true;
            ParkingSlotRequesting = parkingSlotRequesting;
        }

        private ReservationRequest()
        {
        }
    }
}