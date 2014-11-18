using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsolePhonebookDB.Entity;
using ConsolePhonebookDB.Repository;

namespace ConsolePhonebookDB.Service
{
    public class AuthenticationService
    {
        public static User LoggedUser { get; private set; }
        private static UsersRepository userRepo = new UsersRepository();

        public static void AuthenticateUser(User user)
        {
            AuthenticationService.LoggedUser = userRepo.GetByUsernameAndPassword(user);
        }
        public static void AuthenticatNewAccount(User user)
        {
            AuthenticationService.LoggedUser = userRepo.AddUser(user);
        }

        public static void AuthenticatLogoutAccount(User user)
        {
            AuthenticationService.LoggedUser = null;
        }
    }
}
