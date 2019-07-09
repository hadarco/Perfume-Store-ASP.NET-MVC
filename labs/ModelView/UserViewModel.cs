using labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labs.ModelView
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Users { get; set; }
    }
}