using AssessmentBrandStudio.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Data
{
    public class EmployeeContextSeedData
    {
        private DataEmployeeContext _context;
        private UserManager<ApplicationUser> _userManager;

        public EmployeeContextSeedData(DataEmployeeContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public void InitializeData()
        {
            CreateEmployees();
        }

        private void CreateEmployees()
        {
            if (!_context.Employees.Any())
            {
                _context.Employees.Add(new Employee()
                {
                
                    FirstName = "Star",
                    Surname = "Zuma",
                    UserRole = "Admin",
                    DateOfBirth = new DateTime(2014, 6, 4),
                    Email = "sonwabilestarzuma@gmail.com",
                    UserId = 1,
                    EmployeeStatusId = 1,
                    Active = true
                });

                _context.Employees.Add(new Employee()
                {
                  
                    FirstName = "Sonwabo",
                    Surname = "Zuma",
                    UserRole = "User",
                    DateOfBirth = new DateTime(1955, 6, 4),
                    Email = "sonwabilestarzuma@gmail.com",
                    UserId = 1,
                    EmployeeStatusId = 1,
                    Active = true
                });

                _context.Employees.Add(new Employee()
                {
                  
                    FirstName = "Pure",
                    Surname = "Placements",
                    UserRole = "Admin",
                    DateOfBirth = new DateTime(1965, 6, 4),
                    Email = "sonwabilezuma@gmail.com",
                    UserId = 1,
                    EmployeeStatusId = 1,
                    Active = true
                });
                _context.Employees.Add(new Employee()
                {
                    
                    FirstName = "Pure",
                    Surname = "Placements",
                    UserRole = "Admin",
                    DateOfBirth = new DateTime(1965, 6, 4),
                    Email = "sonwabilezuma@gmail.com",
                    UserId = 1,
                    EmployeeStatusId = 1,
                    Active = true
                });
                _context.SaveChanges();
            }
        }

    }
}