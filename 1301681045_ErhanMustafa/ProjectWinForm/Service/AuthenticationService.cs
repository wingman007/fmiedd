using ProjectWinForm.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWinForm
{
    class AuthenticationService
    {
        public static User LoggedUser { get; private set; }
        public static void AuthenticateUser(string username, string password)
        {
            UsersRepository usersRepo = new UsersRepository();
            AuthenticationService.LoggedUser = usersRepo.GetByUserNameandPassword(username, password);
        }
    }
}
