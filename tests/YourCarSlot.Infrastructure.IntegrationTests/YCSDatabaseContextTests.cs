using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.IntegrationTests;

public sealed class YCSDatabaseContextTests
{
    private readonly YCSDatabaseContext _ycsDatabaseContext;
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;

    public YCSDatabaseContextTests()
    {
        var dbOptions = new DbContextOptionsBuilder<YCSDatabaseContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

        _ycsDatabaseContext = new YCSDatabaseContext(dbOptions);
    }

    [Fact]
    public async void SaveSetDateCreatedValue()
    {
        var stringGuid = Guid.Parse("81a130d2-502f-4cf1-a376-63edeb000e9f");
        var userrequestingExample = Guid.Parse("36b99c90-b13d-11ed-afa1-0242ac120002");
        var reservationRequest = new ReservationRequest
        {
            Id = stringGuid,
            BookingRequestTime = DateTime.UtcNow,
            Reserved = true,
            PlateNumber = "23233-33",
            UserRequestingId = userrequestingExample,
            CreatedAt = DateTime.Now,
            DateModified = DateTime.Now
        };

        await _ycsDatabaseContext.ReservationRequest.AddAsync(reservationRequest);
        await _ycsDatabaseContext.SaveChangesAsync(_cancellationToken);

        reservationRequest.CreatedAt.Should().NotBeNull();
    }

    [Fact]
    public async void SaveSetDateModifiedValue()
    {
        var stringGuid = Guid.Parse("81a130d2-502f-4cf1-a376-63edeb000e9f");
        var userrequestingExample = Guid.Parse("36b99c90-b13d-11ed-afa1-0242ac120002");
        var reservationRequest = new ReservationRequest
        {
            Id = stringGuid,
            BookingRequestTime = DateTime.UtcNow,
            Reserved = true,
            PlateNumber = "23233-33",
            UserRequestingId = userrequestingExample,
            CreatedAt = DateTime.Now,
            DateModified = DateTime.Now
        };

        await _ycsDatabaseContext.ReservationRequest.AddAsync(reservationRequest);
        await _ycsDatabaseContext.SaveChangesAsync();

        reservationRequest.DateModified.Should().NotBeNull();
    }
}