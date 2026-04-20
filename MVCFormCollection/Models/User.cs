using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormCollection.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}