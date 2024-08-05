using AutoMapper;
using FluentAssertions;
using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.Logging;
using YourCarSlot.Application.MappingProfiles;
using YourCarSlot.Application.UnitTests.Mocks;

namespace YourCarSlot.Application.UnitTests.Features.ReservationRequest.Queries;

public sealed class GetReservationRequestQueryHandlerTests
{
    private readonly Mock<IReservationRequestRepository> _mockRepo;
    private readonly IMapper _mapper;
    private readonly Mock<IAppLogger<ReservationRequestQueryHandler>> _mockAppLogger;
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;

    public GetReservationRequestQueryHandlerTests()
    {
        _mockRepo = MockReservationRequestRepository.GetReservationRequestMockRepository();

        var mapperConfig = new MapperConfiguration(c => 
        {
            c.AddProfile<ReservationProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
        _mockAppLogger = new Mock<IAppLogger<ReservationRequestQueryHandler>>();
    }


    [Fact]
    public async Task GetSingleReservationRequestTest()
    {
        // ARRANGE
        var testGuid = Guid.Parse("4c750373-6309-40c8-af68-973aaf8da562");
        var handler = new ReservationRequestQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

        // ACT
        var query = new ReservationRequestQuery(testGuid);
        var result = await handler.Handle(query, _cancellationToken);

        // ASSERT
        result.Should().BeOfType<ReservationRequestDto>();
        result.Should().NotBeNull();
    }
}