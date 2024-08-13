using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Identity;
using YourCarSlot.Application.Models.Identity;

namespace YourCarSlot.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("Login")]
    public async Task<ActionResult<AuthResponse>> Login(AuthRequest request, CancellationToken cancellationToken)
    {
        return Ok(await _authenticationService.Login(request, cancellationToken));
    }

    [HttpPost("Register")]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request, CancellationToken cancellationToken)
    {
        return Ok(await _authenticationService.Register(request, cancellationToken));
    }
}