using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class EmptyPlateNumberException : YourCarSlotException
    {
        public EmptyPlateNumberException() : base("Plate numbers cannot be empty ")
        {
        }
    }
}