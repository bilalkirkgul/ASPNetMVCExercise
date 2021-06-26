using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20_Cookie.Models
{
    public class UserVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}