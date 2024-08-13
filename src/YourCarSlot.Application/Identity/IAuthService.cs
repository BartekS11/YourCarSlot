using YourCarSlot.Application.Models.Identity;

namespace YourCarSlot.Application.Identity;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request, CancellationToken cancellationToken = default);
    Task<RegistrationResponse> Register(RegistrationRequest request, CancellationToken cancellationToken = default);
}