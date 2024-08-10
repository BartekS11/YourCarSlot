using FluentValidation.Results;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Application.Exceptions;

public sealed class BadRequestException : YourCarSlotException
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        ValidationErrors = validationResult.ToDictionary();
        // ValidationError(validationResult.ToDictionary());
    }

    public IDictionary<string, string[]> ValidationErrors { get; set; } = default!;
    public IReadOnlyDictionary<string, string[]> ValidationError { get; set; } = default!;
}