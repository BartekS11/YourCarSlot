using YourCarSlot.Application.Models.Identity;

namespace YourCarSlot.Application.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);
    }
}