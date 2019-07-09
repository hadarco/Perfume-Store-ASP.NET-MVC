using labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labs.ModelView
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
    }
}