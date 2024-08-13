using FluentValidation;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser;

public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(p=> p.Email)
            .NotNull()
            .WithMessage("{PropertyName} cannot be null");
        
    }   
}
