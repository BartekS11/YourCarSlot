using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<CreateReservationCommandHandler> _logger;

        public CreateReservationCommandHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository, IAppLogger<CreateReservationCommandHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
            _reservationRequestRepository = reservationRequestRepository ?? throw new ArgumentNullException(nameof(reservationRequestRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateReservationCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                _logger.LogWarning("Create reservation request not valid");
                throw new BadRequestException("Invalid CreateReservation type", validatorResult);   
            }

            var reservationRequestToCreate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.CreateAsync(reservationRequestToCreate);

            _logger.LogTraceInformation("Reservation request created successfuly");

            return reservationRequestToCreate.Id;
        }
    }
}