using Azure.Core;
using Microsoft.AspNetCore.Identity;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Identity;
using YourCarSlot.Application.Models.Identity;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Identity.Models;

namespace YourCarSlot.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task<Employee> GetEmployee(string userId)
        {
            var employee = await _userManager.FindByIdAsync(userId) ?? throw new NotFoundException($"Employee with userId {userId} not found.");
            return new Employee
            {
                Email = employee.Email,
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };

        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _userManager.GetUsersInRoleAsync("Employee") ?? throw new NotFoundException($"Employees with role 'Employee' not found.");
            return employees.Select(q => new Employee
            {
                Id = q.Id,
                Email = q.Email,
                FirstName = q.FirstName,
                LastName = q.LastName
            }).ToList();
        }
    }
}