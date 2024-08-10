namespace YourCarSlot.Application.Models.Identity;

public sealed class AuthRequest
{
    public string Email { get; init; } = default!;
    public string Password { get; init; } = default!;
}