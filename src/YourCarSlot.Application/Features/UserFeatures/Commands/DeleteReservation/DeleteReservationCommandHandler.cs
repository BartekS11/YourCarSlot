using MediatR;
using YourCarSlot.Application.Contracts.Logging;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, Unit>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<DeleteReservationCommandHandler> _logger;

        public DeleteReservationCommandHandler(IReservationRequestRepository reservationRequestRepository,
            IAppLogger<DeleteReservationCommandHandler> logger)
        {
            this._reservationRequestRepository = reservationRequestRepository;
            this._logger = logger;
        }

        public async Task<Unit> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteReservationCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                _logger.LogWarning("Validation errors {0}", request.Id);
                throw new BadRequestException("Invalid DeleteReservation type", validatorResult);   
            }

            var reservationToDelete = await _reservationRequestRepository.GetByIdAsync(request.Id);

            await _reservationRequestRepository.DeleteAsync(reservationToDelete);            

            return Unit.Value;
        }
    }
}