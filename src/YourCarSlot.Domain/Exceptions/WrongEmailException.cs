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