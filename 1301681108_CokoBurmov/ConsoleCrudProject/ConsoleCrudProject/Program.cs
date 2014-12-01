using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCrudProject.View;

namespace ConsoleCrudProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username : ");
            string uname = Console.ReadLine();
            Console.Write("Password : ");
            string pass = Console.ReadLine();
            Console.Clear();

            if (uname == "admin" && pass == "admin")
            {
                LoginView loginView = new LoginView();
                loginView.Show();
            }
            else
            {
                LoginViewUser userLogin = new LoginViewUser();
                userLogin.Show();
            }

        }
    }
}
