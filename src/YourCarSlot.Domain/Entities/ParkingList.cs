using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingList
    {
        public Guid Id { get; private set; }
        private ParkingListName _name;
        private Localization _localization;

        internal ParkingList(Guid id, ParkingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;            
        }
    }
}