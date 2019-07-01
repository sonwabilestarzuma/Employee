using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentBrandStudio.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string SurName { get; set; }

        [Required]
        [StringLength(20)]
        public string UserRole { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public bool Active { get; set; }

        [Required]
        [Display(Name = "Employee Status")]
        public EmployeeStatus EmployeeStatus { get; set; }

        public int UserId { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public Employee Employee { get; set; }
    }
}
