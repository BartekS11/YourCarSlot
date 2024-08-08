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