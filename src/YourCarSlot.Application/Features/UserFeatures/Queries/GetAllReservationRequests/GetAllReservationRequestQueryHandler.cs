using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            this._mapper = mapper;
            this._reservationrequestRepository = reservationrequestRepository;
            this._logger = logger;
        }

        public async Task<List<ReservationRequestDto>> Handle(GetAllReservationRequestQuery request, CancellationToken cancellationToken)
        {
            var reservationTypes = await _reservationrequestRepository.GetAsync();
            if(reservationTypes == null)
            {
                throw new NotFoundException(nameof(reservationTypes));   
                _logger.LogWarning("Cannot find any reservation request", nameof(reservationTypes));
            }
            var data = _mapper.Map<List<ReservationRequestDto>>(reservationTypes);

            return data;
        }
    }
}