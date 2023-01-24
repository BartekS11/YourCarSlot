using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, Unit>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public DeleteReservationCommandHandler(IReservationRequestRepository reservationRequestRepository)
        {
            this._reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Unit> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteReservationCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                throw new BadRequestException("Invalid DeleteReservation type", validatorResult);   
            }

            var reservationToDelete = await _reservationRequestRepository.GetByIdAsync(request.Id);

            await _reservationRequestRepository.DeleteAsync(reservationToDelete);            

            return Unit.Value;
        }
    }
}