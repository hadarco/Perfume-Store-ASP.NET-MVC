using labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labs.ModelView
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

    }
}