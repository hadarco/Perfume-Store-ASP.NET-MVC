using labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labs.ModelView
{
    public class SupplierViewModel
    {
        public Supplier Supplier { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}