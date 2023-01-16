using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class EmptyParkingListException : YourCarSlotException
    {
        public EmptyParkingListException() : base("parking list name cannot be empty")
        {
            
        }
    }
}