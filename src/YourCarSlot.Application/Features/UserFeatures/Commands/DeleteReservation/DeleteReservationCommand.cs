using MediatR;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;

public class DeleteReservationCommand : IRequest<Unit>
{
    public Guid Id { get; init; }
}