using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labs.Models
{
    public class User
    {
        [Required]
        [Key]
        [RegularExpression("^[A-Za-z][A-Za-z0-9]+$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string UserName { get; set; }

        [Required]
       // [RegularExpression("^[1-9]{5}$", ErrorMessage = "Serial number must be 5 numbers (digits 1-9)")]
        public string Password { get; set; }

       
        public bool Admin { get; set; }
    }
}