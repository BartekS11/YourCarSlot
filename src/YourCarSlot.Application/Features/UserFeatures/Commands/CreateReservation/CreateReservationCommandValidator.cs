using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommandValidator : AbstractValidator<CreateReservationCommand>
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
            return !date.Equals(default(DateTime));
        }
    }
}