using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ReservationRequest : BaseEntity
    {
        public enum PartOfTheDay { AM, PM };
        public PartOfTheDay PartOfTheDayReservation { get;  set; }
        public DateTime BookingRequestTime { get;  set; }
        // public User UserRequesting { get;  set; }
        public Guid UserRequestingId { get;  set; }
        public int ParkingSlotRequesting { get;  set; }
        public bool Reserved { get;  set; } = false;
        public string PlateNumber { get; set; }  = string.Empty;
        public ReservationRequest(DateTime bookingrequesttime,
                                  Guid userrequesting,
                                  PartOfTheDay partoftheday, int parkingSlotRequesting)
        {
            Id = Guid.NewGuid();
            BookingRequestTime = bookingrequesttime;
            UserRequestingId = userrequesting;
            PartOfTheDayReservation = partoftheday;
            Reserved = true;
            ParkingSlotRequesting = parkingSlotRequesting;
        }

        public ReservationRequest()
        {
        }
    }
}