using YourCarSlot.Application.Models.Identity;

namespace YourCarSlot.Application.Identity
{
    public interface IUserService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(string userId);
    }
}