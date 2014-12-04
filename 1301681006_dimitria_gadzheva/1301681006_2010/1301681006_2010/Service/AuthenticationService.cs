using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1301681006_2010.Entity;
using _1301681006_2010.Repository;

namespace _1301681006_2010.Service
{
    class AuthenticationService
    {
        public static User LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            userRepository userRepo = new userRepository();
            AuthenticationService.LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
        }
    }
}
