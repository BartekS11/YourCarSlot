using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class WrongPasswordException : YourCarSlotException
    {
        public WrongPasswordException() : base("Wrong password")
        {
        }
    }
}