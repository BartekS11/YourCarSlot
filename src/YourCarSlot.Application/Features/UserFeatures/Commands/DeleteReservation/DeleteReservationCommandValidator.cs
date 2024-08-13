using FluentValidation;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;

internal sealed class DeleteReservationCommandValidator : AbstractValidator<DeleteReservationHandler.Command>
{
    public DeleteReservationCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotNull();
    }
}