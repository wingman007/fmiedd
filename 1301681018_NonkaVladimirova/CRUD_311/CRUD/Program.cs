using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        static void Login()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("Enter your username :");
            string username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your password :");
            string pass = Convert.ToString(Console.ReadLine());

            AuthenticationService.AuthenticateUser(username, pass);

            if (AuthenticationService.LoggedUser == null)
            {
                Login();
            }
        }

        static void Main(string[] args)
        {
            Login();

            UserRepository.GetRole(AuthenticationService.LoggedUser);

            Menu menu = new Menu();
            menu.Show();
        }
    }
}
