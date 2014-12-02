using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;
using System.Collections;
using System.Collections.Specialized;

namespace BookManager.Controllers
{
    class UserController
    {
         public static User LogIn(string username, string password)
        {
            User LoggedUser = new User();
            LoggedUser = UserModel.LogIn(username, password);
            return LoggedUser;
        }
    }
}
