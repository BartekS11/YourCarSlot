using FluentValidation;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;

public class DeleteReservationCommandValidator : AbstractValidator<DeleteReservationCommand>
{
    public DeleteReservationCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotNull();
    }
}