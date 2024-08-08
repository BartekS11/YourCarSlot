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