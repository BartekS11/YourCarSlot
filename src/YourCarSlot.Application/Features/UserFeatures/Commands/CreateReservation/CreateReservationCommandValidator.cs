using FluentValidation;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;

internal sealed class CreateReservationCommandValidator : AbstractValidator<CreateReservationHandler.Command>
{
    public CreateReservationCommandValidator()
    {
        RuleFor(p => p.UserRequestingId)
            .NotEmpty()
            .NotNull()
            .WithMessage("{PropertyName} must be fewer than 70 characters");

        RuleFor(p => p.BookingRequestTime)
            .Must(BeAValidDate).WithMessage("Must be proper date");
        
    }

    private bool BeAValidDate(DateTime date)
    {
        return !date.Equals(default);
    }
}
