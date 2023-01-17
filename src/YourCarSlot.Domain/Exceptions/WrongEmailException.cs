using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class WrongEmailException : YourCarSlotException
    {
        public WrongEmailException() : base("Email is wrong, enter correct email address")
        {
        }
    }
}