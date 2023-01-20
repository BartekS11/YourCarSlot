using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public class ReservationRequestQueryHandler : IRequestHandler<ReservationRequestQuery, ReservationRequestDto>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public ReservationRequestQueryHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository)
        {
            this._mapper = mapper;
            this._reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<ReservationRequestDto> Handle(ReservationRequestQuery request, CancellationToken cancellationToken)
        {
            var reservationRequestType = await _reservationRequestRepository.GetByIdAsync(request.Id);

            var data = _mapper.Map<ReservationRequestDto>(reservationRequestType);

            return data;
        }
    }
}