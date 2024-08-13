using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;

public sealed class DeleteReservationHandler
{
    public sealed record Command(Guid Id) : IRequest<Unit>;

    internal sealed class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public Handler(IReservationRequestRepository reservationRequestRepository)
        {
            _reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationToDelete = await _reservationRequestRepository.GetByIdAsync(request.Id, cancellationToken)
                ?? throw new NotFoundException($"User to delete with {request.Id} is already deleted or not exists");

            await _reservationRequestRepository.DeleteAsync(reservationToDelete!, cancellationToken);            

            return Unit.Value;
        }
    }
}
