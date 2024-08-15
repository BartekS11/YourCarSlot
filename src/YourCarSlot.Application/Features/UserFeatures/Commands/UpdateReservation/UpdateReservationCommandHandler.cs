using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;

public sealed class UpdateReservationHandler
{
    public sealed record Command(
        Guid Id,
        int ParkingSlotRequesting,
        Guid UserRequestingId,
        PartOfTheDay PartOfTheDayReservation,
        DateTime BookingRequestTime,
        string PlateNumber) : IRequest<Unit>;

    internal sealed class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public Handler(IReservationRequestRepository reservationRequestRepository)
        {
            _reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationToUpdate = ReservationRequestMapper.Map(request);

            await _reservationRequestRepository.UpdateAsync(reservationToUpdate, cancellationToken);

            return Unit.Value;
        }
    }
}
