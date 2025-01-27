using EmployAdminPortal.Models.Entities;

namespace EmployAdminPortal.Repositories.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        // Add any Employee-specific methods here
        Task<IEnumerable<Employee>> GetEmployeesWithHighSalariesAsync(decimal salaryThreshold);
    }
}
