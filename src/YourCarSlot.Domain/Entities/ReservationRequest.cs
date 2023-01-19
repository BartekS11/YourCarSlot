using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities
{
    public class ReservationRequest : BaseEntity
    {
        public enum PartOfTheDay { AM, PM };
        public PartOfTheDay PartOfTheDayReservation { get; protected set; }
        public DateTime BookingRequestTime { get; protected set; }
        public User UserRequesting { get; protected set; }
        public ParkingList ParkingListRequesting { get; protected set; }

        public ReservationRequest(Guid id, DateTime bookingrequesttime, 
                                  User userrequesting, ParkingList parkinglistrequesting,
                                  PartOfTheDay partoftheday)
        {
            Id = id;
            BookingRequestTime = bookingrequesttime;
            UserRequesting = userrequesting;
            ParkingListRequesting = parkinglistrequesting;
            PartOfTheDayReservation = partoftheday;
        }        
    }
}