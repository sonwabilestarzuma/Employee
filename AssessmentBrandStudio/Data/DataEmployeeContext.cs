using AssessmentBrandStudio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Data
{
    public class DataEmployeeContext : IdentityDbContext<ApplicationUser>
    {
        public DataEmployeeContext(DbContextOptions<DataEmployeeContext> options)
             : base(options)
        {
            
    }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
    }
}

