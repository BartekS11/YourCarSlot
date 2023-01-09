using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingList
    {
        public Guid Id { get; private set; }
        private string _name;
        private string _localization;

    }
}