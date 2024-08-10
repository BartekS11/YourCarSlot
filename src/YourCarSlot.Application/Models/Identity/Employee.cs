namespace YourCarSlot.Application.Models.Identity;

public sealed class Employee
{
    public string Id { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
}