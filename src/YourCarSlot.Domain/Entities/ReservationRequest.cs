using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities
{
    public class ReservationRequest : BaseEntity
    {
        public ReservationRequest(Guid id, DateTime bookingrequesttime, 
                                  User userrequesting, ParkingList parkinglistrequesting)
        {
            Id = id;
            BookingRequestTime = bookingrequesttime;
            UserRequesting = userrequesting;
            ParkingListRequesting = parkinglistrequesting;
        }

        public DateTime BookingRequestTime { get; protected set; }
        public User UserRequesting { get; protected set; }
        public ParkingList ParkingListRequesting { get; protected set; }
    }
}