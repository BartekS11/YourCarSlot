using System.ComponentModel.DataAnnotations;

namespace YourCarSlot.Application.Models.Identity;

public sealed class RegistrationRequest
{
    [Required]
    public string FirstName { get; init; } = default!;

    [Required]
    public string LastName { get; init; } = default!;

    [Required]
    [EmailAddress]
    public string Email { get; init; } = default!;

    [Required]
    [MinLength(6)]
    public string UserName { get; init; } = default!;

    [Required]
    [MinLength(6)]
    public string Password { get; init; } = default!;
}