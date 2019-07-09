using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labs.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        [RegularExpression("^[1-9]{5}$", ErrorMessage = "Supplier Id must be 5 digits (digits 1-9)")]
        public string SupplierId { get; set; }


        [Required]
        [RegularExpression("^[A-Za-z ][A-Za-z0-9]+$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string SupplierEmail { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z ][A-Za-z0-9]+$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string SupplierAddress { get; set; }

        [Required]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Use numbers only, Must be 10 digits")]
        public string SupplierPhoneNumber { get; set; }

    }
}