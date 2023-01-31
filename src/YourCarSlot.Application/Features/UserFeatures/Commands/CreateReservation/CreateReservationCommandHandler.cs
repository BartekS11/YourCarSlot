using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Logging;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<CreateReservationCommandHandler> _logger;

        public CreateReservationCommandHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository,
            IAppLogger<CreateReservationCommandHandler> logger)
        {
            this._mapper = mapper;
            this._reservationRequestRepository = reservationRequestRepository;
            this._logger = logger;
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateReservationCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                _logger.LogInformation("Invalid reservation type {0}", request.ParkingSlotRequesting);
                throw new BadRequestException("Invalid CreateReservation type", validatorResult);   
            }

            var reservationRequestToCreate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.CreateAsync(reservationRequestToCreate);

            return reservationRequestToCreate.Id;
        }
    }
}