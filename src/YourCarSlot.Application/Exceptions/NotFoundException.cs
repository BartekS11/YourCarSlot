using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Application.Exceptions;

public sealed class NotFoundException : YourCarSlotException
{
    public NotFoundException(string message, object key) : base($"{message}, ({key}) was not found")
    {
    }

    public NotFoundException(string message) : base($"{message}, was not found")
    {
    }
}
