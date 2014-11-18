using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectX.View;

namespace ProjectX.Repository
{
    public class UserRepository
    {       
        public static void AuthenticateUser(string username, string password)
        {
            if (username == "user1" && password == "user1")
            {
                Console.WriteLine("Successful Login ! ");

            }
            else
            {
                Console.WriteLine("Wrong username or password !");
            }

        }
        
    }
}
