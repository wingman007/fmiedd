using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD2.Models;

namespace CRUD2.Service
{
    public class AuthenticationService
    {
        public static string Logged { get; private set; }
        public static void AuthenticateUser(string name, string password)
        {
            Repo userRepo = new Repo();
            AuthenticationService.Logged = userRepo.GetByUserNameAndPassword(name, password);
        }
    }
}