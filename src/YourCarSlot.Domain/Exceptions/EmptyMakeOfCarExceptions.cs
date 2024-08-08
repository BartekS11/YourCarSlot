using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions;

public class EmptyMakeOfCarExceptions : YourCarSlotException
{
    public EmptyMakeOfCarExceptions() : base("Make of car cannot by empty")
    {
    }
}