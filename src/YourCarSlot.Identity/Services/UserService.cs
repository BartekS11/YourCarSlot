using Microsoft.AspNetCore.Identity;
using YourCarSlot.Application.Identity;
using YourCarSlot.Application.Models.Identity;
using YourCarSlot.Identity.Models;

namespace YourCarSlot.Identity.Services;

public sealed class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<Employee> GetEmployee(string userId, CancellationToken cancellationToken)
    {
        var employee = await _userManager.FindByIdAsync(userId);
        return new Employee
        {
            Email = employee!.Email!,
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName
        };

    }

    public async Task<List<Employee>> GetEmployees(CancellationToken cancellationToken)
    {
        var employees = await _userManager.GetUsersInRoleAsync("Employee");
        return employees.Select(q => new Employee
        {
            Id = q.Id,
            Email = q.Email!,
            FirstName = q.FirstName,
            LastName = q.LastName
        }).ToList();
    }
}