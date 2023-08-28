using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, Unit>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<DeleteReservationCommandHandler> _logger;

        public DeleteReservationCommandHandler(IReservationRequestRepository reservationRequestRepository, IAppLogger<DeleteReservationCommandHandler> logger)
        {
            _reservationRequestRepository = reservationRequestRepository ?? throw new ArgumentNullException(nameof(reservationRequestRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
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

            _logger.LogTraceInformation("Reservation request deleted successfuly");

            return Unit.Value;
        }
    }
}