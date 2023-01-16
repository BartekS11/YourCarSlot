using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Shared.Abstractions.Exceptions
{
    public abstract class YourCarSlotException : Exception
    {
        protected YourCarSlotException(string message) : base(message)
        {
            
        }   
    }
}