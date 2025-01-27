using EmployAdminPortal.Data;
using EmployAdminPortal.Models.Entities;
using EmployAdminPortal.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployAdminPortal.Repositories.Implementations
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesWithHighSalariesAsync(decimal salaryThreshold)
        {
            return await _context.Employees
                .Where(e => e.Salary > salaryThreshold)
                .ToListAsync();
        }
    }
}
