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
            Console.Clear();

            Console.WriteLine("Username :");
            string username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Password :");
            string pass = Convert.ToString(Console.ReadLine());

            Authentication.AuthenticateUser(username, pass);

            if (Authentication.LoggedUser == null)
            {
                Login();
            }
        }
        static void Main(string[] args)

        {
            Menu menu = new Menu();
            Login();
            UserRepository.GetRole(Authentication.LoggedUser);
            if (Authentication.LoggedUser.Role == "admin")
            {
                menu.Show();
            }
           if (Authentication.LoggedUser.Role=="member")
           {
           menu.Member();
           }
        }
    }
}
