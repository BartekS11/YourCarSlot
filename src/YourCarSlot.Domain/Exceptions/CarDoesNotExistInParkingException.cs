using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class CarDoesNotExistInParkingException : YourCarSlotException
    {
        public CarDoesNotExistInParkingException() : base("Car must exist in car park")
        {

        }
    }
}