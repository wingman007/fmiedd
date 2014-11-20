using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task2_Web.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Role_id { get; set; }
        public string Role { get; set; }
    }
}