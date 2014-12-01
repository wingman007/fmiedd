using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Authentication
    {
        public static User LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            Authentication.LoggedUser = UserRepository.GetByUsernameAndPassword(username, password);
        }
    }
}
