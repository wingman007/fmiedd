using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.Repository;
using projectWeek10.Entity;

namespace projectWeek10.Service
{
    public class AuthenticationService
    {
        public static User LoggedUser { get; set; }
        public static void AuthenticateUser(string username, string password)
        {
            UserRepository user = new UserRepository();
            LoggedUser = user.GetByUsernameAndPassword(username, password);
        }
    }
}
