using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class WrongUsernameException : YourCarSlotException
    {
        public WrongUsernameException() : base("Username is wrong")
        {
            
        }
    }
}