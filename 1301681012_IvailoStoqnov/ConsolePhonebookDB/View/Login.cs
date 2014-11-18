using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsolePhonebookDB.Tools;
using ConsolePhonebookDB.Service;
using ConsolePhonebookDB.Entity;

namespace ConsolePhonebookDB.View
{
    public class Login
    {
        public void Show()
        {
            while (true)
            {
                LoginMenuEnum choise = RenderMenu();
                switch (choise)
                {
                    case LoginMenuEnum.Login:
                    {
                        LoginUser();
                        break;
                    }
                    case LoginMenuEnum.NewAccount:
                    {
                        NewAccount();
                        break;
                    }
                    case LoginMenuEnum.Exit:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                }
                if (AuthenticationService.LoggedUser != null)
                    break;
            }
        }

        private LoginMenuEnum RenderMenu()
        {
            while (true) { 
                Console.Clear();
                Console.WriteLine("Press a key to continue...");
                Console.WriteLine("[L]oggin");
                Console.WriteLine("[N]ew account");
                Console.WriteLine("E[x]it");

                string choise = Console.ReadLine();
                switch (choise.ToUpper())
                {
                    case "L":
                        return LoginMenuEnum.Login;
                    case "N":
                        return LoginMenuEnum.NewAccount;
                    case "X":
                        return LoginMenuEnum.Exit;
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choise!");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey(true);
                        break;
                    }
                }
            }
        }

        private User LoginUser()
        {
            Console.Clear();
            User user = new User();
            Console.Write("Username: ");
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password= Console.ReadLine();

            AuthenticationService.AuthenticateUser(user);
            if (AuthenticationService.LoggedUser != null)
            {
                Console.Clear();
                Console.WriteLine("Welcome " + AuthenticationService.LoggedUser.ToString() + "!");
                Console.ReadKey(true);
                return AuthenticationService.LoggedUser;
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                Console.ReadKey(true);
                return null;
            }
        }

        private User NewAccount()
        {
            Console.Clear();
            User user = new User();
            Console.WriteLine("Creating New Account!");
            Console.Write("Username: ");
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password = Console.ReadLine();
            Console.Write("First Name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            user.LastName = Console.ReadLine();

            if (user.Username == "" || user.Username == "")
            {
                Console.WriteLine("Empty Fields!");
                Console.ReadKey(true);
                return null;
            }
            else
            {
                AuthenticationService.AuthenticatNewAccount(user);
                if (AuthenticationService.LoggedUser != null)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome " + AuthenticationService.LoggedUser.ToString() + "!");
                    Console.ReadKey(true);
                    return AuthenticationService.LoggedUser;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                    Console.ReadKey(true);
                    return null;
                }
            }
        }
    }
}
