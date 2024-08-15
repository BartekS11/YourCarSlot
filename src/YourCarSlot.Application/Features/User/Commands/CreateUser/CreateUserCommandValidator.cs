using FluentValidation;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser;

internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUser.Command>
{
    public CreateUserCommandValidator()
    {
        RuleFor(p => p.Email)
            .NotNull()
            .WithMessage("{PropertyName} cannot be null");
        RuleFor(p => p.Password)
             .NotNull()
             .WithMessage("{PropertyName} cannot be null");
    }
}
