using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentBrandStudio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AssessmentBrandStudio.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataEmployeeContext _context;
        private ILogger<EmployeeRepository> _logger;

        public EmployeeRepository(DataEmployeeContext context, ILogger<EmployeeRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Add(Employee item)
        {
                await _context.Set<Employee>().AddAsync(item);
                await _context.SaveChangesAsync();
        }

        public void AddEmployee(Employee newEmployee)
        {
            _context.Add(newEmployee);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await GetEmployeeByIdAsync(id);
            if (employee == null)
                return false;
            _context.Employees.Remove(employee);
            return (await _context.SaveChangesAsync() > 0);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            _logger.LogInformation("Getting All Employees from the database");
            return _context.Employees.ToList();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees
                        .Where(v => v.Id == id)
                        .FirstOrDefaultAsync();
        }

        public Employee GetEmployeeByName(string employeeName)
        {
            return _context.Employees.Where(x => x.FirstName == employeeName).FirstOrDefault();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task Update(Employee item)
        {
          
                _context.Set<Employee>().UpdateRange(item);
                await _context.SaveChangesAsync();
            }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            return (await _context.SaveChangesAsync() > 0); ;
        }
    }
}
