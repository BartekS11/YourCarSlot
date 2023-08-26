using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public class ReservationRequestQueryHandler : IRequestHandler<ReservationRequestQuery, ReservationRequestDto>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;
        private readonly IAppLogger<ReservationRequestQueryHandler> _logger;

        public ReservationRequestQueryHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository, IAppLogger<ReservationRequestQueryHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _reservationRequestRepository = reservationRequestRepository ?? throw new ArgumentNullException(nameof(reservationRequestRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ReservationRequestDto> Handle(ReservationRequestQuery request, CancellationToken cancellationToken)
        {
            var reservationRequestType = await _reservationRequestRepository.GetByIdAsync(request.Id);

            if(reservationRequestType == null)
            {
                throw new NotFoundException(nameof(reservationRequestType), request.Id);   
            }

            var data = _mapper.Map<ReservationRequestDto>(reservationRequestType);
            _logger.LogInformation("Reservation request were retrieved successfully");
            return data;
        }
    }
}