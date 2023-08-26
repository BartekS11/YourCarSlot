using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests
{
    public class GetAllReservationRequestQueryHandler : IRequestHandler<GetAllReservationRequestQuery, List<ReservationRequestDto>>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationrequestRepository;
        private readonly IAppLogger<GetAllReservationRequestQueryHandler> _logger;

        public GetAllReservationRequestQueryHandler(IMapper mapper, IReservationRequestRepository reservationrequestRepository, IAppLogger<GetAllReservationRequestQueryHandler> logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _reservationrequestRepository = reservationrequestRepository ?? throw new ArgumentNullException(nameof(reservationrequestRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<ReservationRequestDto>> Handle(GetAllReservationRequestQuery request, CancellationToken cancellationToken)
        {
            var reservationTypes = await _reservationrequestRepository.GetAsync();
            if(reservationTypes == null)
            {
                _logger.LogWarning("Cannot find any reservation request", nameof(reservationTypes));
                throw new NotFoundException(nameof(reservationTypes));   
            }
            var data = _mapper.Map<List<ReservationRequestDto>>(reservationTypes);

            return data;
        }
    }
}