using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots
{
    public class ParkingSlotDto
    {
        public Guid Id { get; set; }
        public int? ParkingspotId { get; set; }
    }
}