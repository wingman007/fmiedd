using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_SQL
{
    public class LoginView
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (username == "maria" && password == "mariapass")
                {
                    Console.Write("Welcome! \n\n");
                    Console.ReadKey(true);
                    break;
                }

                else
                {
                    Console.Write("Unvalid username or password!");
                    Console.ReadKey(true);
                }

            }
        }
    }
}
