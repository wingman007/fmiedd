using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task2_Web.Entity;
using Task2_Web.Repository;


namespace Task2_Web.Service
{
    public static class AuthenticationService
    {
        public static string Logged { get; private set; }
        public static void AuthenticateUser(string name, string password)
        {
            UserRepository userRepo = new UserRepository();
            AuthenticationService.Logged = userRepo.GetByUserNammeAndPassword(name,password);
        }
    }
}