using System.ComponentModel.DataAnnotations.Schema;
using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities;

public sealed class ReservationRequest : BaseEntity
{
    public enum PartOfTheDay { AM, PM };
    public PartOfTheDay PartOfTheDayReservation { get; set; }
    public DateTime BookingRequestTime { get;  set; }
    
    [ForeignKey("User")]
    public Guid? UserRequestingId { get; set; }
    public User User { get; set; } = default!;

    [ForeignKey("ParkingSlot")]
    public int? ParkingspotId { get; set; }
    public ParkingSlot ParkingSlot { get; set; } = default!;

    public bool Reserved { get;  set; } = false;

    [ForeignKey("Vehicle")]
    public string? PlateNumber { get; set; }
    public Vehicle Vehicle { get; set; } = default!;

    public ReservationRequest(DateTime bookingrequesttime,
                              Guid userrequesting,
                              PartOfTheDay partoftheday, int parkingspotId)
    {
        Id = Guid.NewGuid();
        BookingRequestTime = bookingrequesttime;
        UserRequestingId = userrequesting;
        PartOfTheDayReservation = partoftheday;
        Reserved = true;
        ParkingspotId = parkingspotId;
    }

    public ReservationRequest()
    {
        Reserved = true;
    }
}