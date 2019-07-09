using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labs.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [RegularExpression("^[1-9]{9}$", ErrorMessage = "Employee Id must be 9 digits (digits 1-9)")]
        public string EmployeeId { get; set; }


        [Required]
        [RegularExpression("^[A-Za-z ]*$", ErrorMessage = "Must use letters only")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmployeeEmail { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z ][A-Za-z0-9]+$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string EmployeeAddress { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "up to 6 digits only")]
        [MinLength(4, ErrorMessage = "min 5 digits")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Use numbers only")]
        public string EmployeeSalary { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z ]*$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string EmployeeJobTitle { get; set; }

    }
}
