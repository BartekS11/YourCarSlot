using Microsoft.AspNetCore.Identity;

namespace YourCarSlot.Identity.Models;

public sealed class ApplicationUser : IdentityUser
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
}