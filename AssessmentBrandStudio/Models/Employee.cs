using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserRole { get; set; }
        public string  Email { get; set; }
        public bool Active { get; set; }

        public int EmployeeStatusId { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }

        public int UserId { get; set; }
    }
}
