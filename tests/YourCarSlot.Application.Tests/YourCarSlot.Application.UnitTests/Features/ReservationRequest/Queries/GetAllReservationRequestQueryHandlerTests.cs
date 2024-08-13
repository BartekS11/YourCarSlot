using FluentAssertions;
using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.UnitTests.Mocks;

namespace YourCarSlot.Application.UnitTests.Features.ReservationRequest.Queries;

public sealed class GetAllReservationRequestQueryHandlerTests
{
    private readonly Mock<IReservationRequestRepository> _mockRepo;
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;

    public GetAllReservationRequestQueryHandlerTests()
    {
        _mockRepo = MockReservationRequestRepository.GetAllReservationRequestMockRepository();

    }

    [Fact]
    internal async Task GetAllReservationRequestListTest()
    {
        // ARRANGE & ACT
        var handler = new GetAllReservationRequestQuery.Handler(_mockRepo.Object);

        var result = await handler.Handle(new GetAllReservationRequestQuery.Command(), _cancellationToken);

        // ASSERT
        result.Should().BeOfType<ReservationRequestDto[]>();
        result.Length.Should().Be(2);
    }
}
