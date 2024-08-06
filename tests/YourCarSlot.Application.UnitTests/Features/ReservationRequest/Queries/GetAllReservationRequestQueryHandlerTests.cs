using AutoMapper;
using FluentAssertions;
using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.Logging;
using YourCarSlot.Application.MappingProfiles;
using YourCarSlot.Application.UnitTests.Mocks;

namespace YourCarSlot.Application.UnitTests.Features.ReservationRequest.Queries;

public sealed class GetAllReservationRequestQueryHandlerTests
{
    private readonly Mock<IReservationRequestRepository> _mockRepo;
    private readonly IMapper _mapper;
    private readonly Mock<IAppLogger<GetAllReservationRequestQuery>> _mockAppLogger;
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;

    public GetAllReservationRequestQueryHandlerTests()
    {
        _mockRepo = MockReservationRequestRepository.GetAllReservationRequestMockRepository();

        var mapperConfig = new MapperConfiguration(c => 
        {
            c.AddProfile<ReservationProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
        _mockAppLogger = new Mock<IAppLogger<GetAllReservationRequestQuery>>();
    }

    [Fact]
    internal async Task GetAllReservationRequestListTest()
    {
        // ARRANGE & ACT
        var handler = new GetAllReservationRequestQuery.Handler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

        var result = await handler.Handle(new GetAllReservationRequestQuery.Command(), _cancellationToken);

        // ASSERT
        result.Should().BeOfType<ReservationRequestDto[]>();
        result.Length.Should().Be(2);
    }
}
