namespace YourCarSlot.Application.Models.Identity;

public sealed class AuthResponse
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
}