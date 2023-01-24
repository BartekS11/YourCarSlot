using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Application.Exceptions
{
    public class NotFoundException : YourCarSlotException
    {
        public NotFoundException(string message, object key) : base("${message}, ({key}) was not found")
        {
        }

        public NotFoundException(string message) : base("${message}, was not found")
        {
        }
    }
}