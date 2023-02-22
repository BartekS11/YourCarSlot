using FluentValidation.Results;
using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Application.Exceptions
{
    public class BadRequestException : YourCarSlotException
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = validationResult.ToDictionary();
        }

        public IDictionary<string, string[]> ValidationErrors { get; set; }
    }
}