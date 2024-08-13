using YourCarSlot.Application.Models.Identity;

namespace YourCarSlot.Application.Identity;

public interface IUserService
{
    Task<List<Employee>> GetEmployees(CancellationToken cancellationToken = default);
    Task<Employee> GetEmployee(string userId, CancellationToken cancellationToken = default);
}