using AutoMapper;
using Moq;
using Shouldly;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Application.Logging;
using YourCarSlot.Application.MappingProfiles;
using YourCarSlot.Application.UnitTests.Mocks;

namespace YourCarSlot.Application.UnitTests.Features.ReservationRequest.Queries
{
    public class GetReservationRequestQueryHandlerTests
    {
        private readonly Mock<IReservationRequestRepository> _mockRepo;
        private readonly IMapper _mapper;
        private readonly Mock<IAppLogger<ReservationRequestQueryHandler>> _mockAppLogger;

        public GetReservationRequestQueryHandlerTests()
        {
            this._mockRepo = MockReservationRequestRepository.GetReservationRequestMockRepository();

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
            var guid1 = "4c750373-6309-40c8-af68-973aaf8da562";
            var handler = new ReservationRequestQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

            var result = await handler.Handle(new ReservationRequestQuery(Guid.Parse(guid1)), CancellationToken.None);

            result.ShouldBeOfType<ReservationRequestDto>();

        }
    }
}