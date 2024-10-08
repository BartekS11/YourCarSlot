namespace YourCarSlot.Application.Models.Identity;

public sealed class JwtSettings
{
    public string Key { get; init; } = default!;
    public string Issuer { get; init; } = default!;
    public string Audience { get; init; } = default!;
    public double DurationInMinutes { get; init; } = default!;
}