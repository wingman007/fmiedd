using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Users
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return UserName + " " + Password + " " + Email;
        }
    }
}
