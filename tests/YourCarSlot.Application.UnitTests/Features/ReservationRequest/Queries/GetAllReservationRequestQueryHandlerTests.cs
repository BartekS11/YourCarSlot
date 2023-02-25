using AutoMapper;
using Moq;
using Shouldly;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.Logging;
using YourCarSlot.Application.MappingProfiles;
using YourCarSlot.Application.UnitTests.Mocks;

namespace YourCarSlot.Application.UnitTests.Features.ReservationRequest.Queries
{
    public class GetAllReservationRequestQueryHandlerTests
    {
        private readonly Mock<IReservationRequestRepository> _mockRepo;
        private readonly IMapper _mapper;
        private readonly Mock<IAppLogger<GetAllReservationRequestQueryHandler>> _mockAppLogger;

        public GetAllReservationRequestQueryHandlerTests()
        {
            this._mockRepo = MockReservationRequestRepository.GetAllReservationRequestMockRepository();

            var mapperConfig = new MapperConfiguration(c => 
            {
                c.AddProfile<ReservationProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockAppLogger = new Mock<IAppLogger<GetAllReservationRequestQueryHandler>>();
        }

        [Fact]
        public async Task GetAllReservationRequestListTest()
        {
            var handler = new GetAllReservationRequestQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

            var result = await handler.Handle(new GetAllReservationRequestQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<ReservationRequestDto>>();
            result.Count.ShouldBe(2);
        }

    }
}