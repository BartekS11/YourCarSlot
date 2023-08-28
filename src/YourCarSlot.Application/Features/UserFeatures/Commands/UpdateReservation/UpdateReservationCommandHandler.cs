using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<UpdateReservationCommandHandler> _logger;

        public UpdateReservationCommandHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository, IAppLogger<UpdateReservationCommandHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _reservationRequestRepository = reservationRequestRepository ?? throw new ArgumentNullException(nameof(reservationRequestRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservationToUpdate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.UpdateAsync(reservationToUpdate);

            _logger.LogTraceInformation("Reservation request updated successfuly");

            return Unit.Value;    
        }
    }
}