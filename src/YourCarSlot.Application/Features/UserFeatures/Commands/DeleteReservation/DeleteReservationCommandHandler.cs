using FluentValidation;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;

public sealed class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, Unit>
{
    private readonly IReservationRequestRepository _reservationRequestRepository;
    private readonly IValidator<DeleteReservationCommand> _validator;

    public DeleteReservationCommandHandler(
        IReservationRequestRepository reservationRequestRepository,
        IValidator<DeleteReservationCommand> validator)
    {
        _reservationRequestRepository = reservationRequestRepository;
        _validator = validator;
    }

    public async Task<Unit> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
    {
        await _validator.ValidateAndThrowAsync(request, cancellationToken);

        var reservationToDelete = await _reservationRequestRepository.GetByIdAsync(request.Id, cancellationToken);

        await _reservationRequestRepository.DeleteAsync(reservationToDelete!, cancellationToken);            

        return Unit.Value;
    }
}