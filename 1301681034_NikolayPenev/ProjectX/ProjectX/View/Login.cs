using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectX.Repository;

namespace ProjectX.View
{
    public class Login
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Username : ");
                string username = Console.ReadLine();

                Console.Write("Password : ");
                string password = Console.ReadLine();

                UserRepository.AuthenticateUser(username, password);

                if (username == "user1")
                {
                    Console.WriteLine("Hi user");
                    Console.ReadKey(true);
                    break;
                }

                   
                Console.ReadKey(true);

            }
        }

    }
}
