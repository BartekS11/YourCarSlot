using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class FullParkingSpaceLimitException : YourCarSlotException
    {
        public FullParkingSpaceLimitException() : base("There is no space left on parking")
        {
        }
    }
}