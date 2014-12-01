using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvader.Models
{
    class AuthenticationService
    {
        public User LoggedUser { get; private set; }

        public void AuthenticateUser(string username, string password)
        {
            UsersRepository userRepo = new UsersRepository();
            LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
        }

        public void CreateUser(string username, string password)
        {
            UsersRepository userRepo = new UsersRepository();
            userRepo.CreateUser(username, password);
            AuthenticateUser(username, password);
        }
    }
}
