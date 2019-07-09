using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labs.Models
{
    public class Product
    {
        [Key]
        [Required]
        [RegularExpression("^[1-9]{5}$", ErrorMessage = "Serial number must be 5 numbers (digits 1-9)")]
        public string ProductNumber { get; set; }


        [Required]
        [RegularExpression("^[A-Za-z][A-Za-z0-9]+$", ErrorMessage = "Can use numbers and letters, must start with a letter")]
        public string ProductName { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}$", ErrorMessage = "Product Cost must be between 100-999 shekels")]
        public string ProductCost { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Must be a positive, non-zero number")]
        public string ProductQuantity { get; set; }



    }
}