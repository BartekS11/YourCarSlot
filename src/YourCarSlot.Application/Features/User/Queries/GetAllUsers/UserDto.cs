namespace YourCarSlot.Application.Features.User.Queries.GetAllUsers;

public class UserDto
{
    public Guid Id { get; init; }
    public string Email { get; init; } = default!;
    public string Username { get; init; } = default!;
    public string? PlateNumber { get; init; } = default!;
}