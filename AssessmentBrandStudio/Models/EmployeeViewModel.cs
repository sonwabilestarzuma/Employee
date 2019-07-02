using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Models
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
        public EmployeeStatus EmployeeStatuses { get; set; }
    }
}
