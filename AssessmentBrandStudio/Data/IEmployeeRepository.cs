using AssessmentBrandStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeByName(string employeeName);
        Task<bool> UpdateEmployeeAsync(Employee employee);
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<bool> SaveChangesAsync();
        Task Update(Employee employee);
        Task Add(Employee employee);
        void AddEmployee(Employee newEmployee);
    }
}
