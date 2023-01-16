using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Domain.Exceptions;

namespace YourCarSlot.Domain.ValueObjects
{
    public record Car
    {
        public string MakeOfCar { get; }
        public string PlateNumber { get; }
        public Localization CarLocalization { get; }
        public bool IsParked { get; }

        public Car(string makeofcar, string platenumber, 
                   Localization carlocalization, bool isparked)
        {
            if(string.IsNullOrWhiteSpace(makeofcar))
            {
                throw new EmptyMakeOfCarExceptions();
            }

            if(string.IsNullOrWhiteSpace(platenumber))
            {
                throw new EmptyPlateNumberException();
            }
            
            MakeOfCar = makeofcar;
            PlateNumber = platenumber;
            CarLocalization = carlocalization;
            IsParked = isparked;   
        }
    }
}