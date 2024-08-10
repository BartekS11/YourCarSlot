namespace YourCarSlot.Application.Models.Identity;

public sealed class AuthResponse
{
    public string Id { get; init; } = default!;
    public string UserName { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string Token { get; init; } = default!;
}