using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{   
    class Menu
    {
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            while (true)
            {
                if (AuthenticationService.LoggedUser.Role == "admin")
                    AdminMenu();
                if (AuthenticationService.LoggedUser.Role == "member")
                    MemberMenu();
                else
                {
                   Console.WriteLine("Hello " + AuthenticationService.LoggedUser.Full_Name);
                   break;
                }
            }
        }

        private void AdminMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Users management:");
                Console.WriteLine("[G]et all users");
                Console.WriteLine("[A]dd user");
                Console.WriteLine("[E]dit User");
                Console.WriteLine("[D]elete User");
                Console.WriteLine("E[x]it");

                string key = Console.ReadLine();
                switch (key.ToUpper())
                {
                    case "G":
                        {
                            GetAll();
                            break;
                        }
                    case "A":
                        {
                            Add();
                            break;
                        }
                    case "D":
                        {
                            Delete();
                            break;
                        }
                    case "X":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case "E":
                        {
                            Edit();
                            break; 
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice.");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }

        private void MemberMenu()
        {
            Console.Clear();
            Console.WriteLine("Users management:");
            Console.WriteLine("[G]et all users");
            Console.WriteLine("E[x]it");

            string key = Console.ReadLine();
            switch (key.ToUpper())
            {
                case "G":
                    {
                        GetAll();
                        break;
                    }
                case "X":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice.");
                        Console.ReadKey(true);
                        break;
                    }
            }
        }

        private void GetAll()
        {           
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            UserRepository UserRepository = new UserRepository();
            List<User> users = UserRepository.GetAll();

            foreach (User user in users)
            {
                Console.WriteLine("ID:" + user.ID);
                Console.WriteLine("Username :" + user.Username);
                Console.WriteLine("Full Name :" + user.Full_Name);
                Console.WriteLine("Email :"+user.Email);
                Console.WriteLine("______________________________________________");
            }

            Console.ReadKey(true);
        }

        private void Add()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            User user = new User();

            Console.WriteLine("Add new User:");
            Console.Write("Username: " );
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password = Console.ReadLine();
            Console.Write("Full Name: ");
            user.Full_Name = Console.ReadLine();
            Console.Write("Email: ");
            user.Email = Console.ReadLine();

            UserRepository userRepository = new UserRepository();
            userRepository.Add(user);            
            Console.ReadKey(true);
        }

        private void Delete()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            UserRepository userRepository = new UserRepository();

            Console.WriteLine("Delete User:");
            Console.Write("Username: ");
            string username = Console.ReadLine();

            userRepository.Delete(username);
            Console.ReadKey(true);
        }

        private void Edit()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            User user = new User();
            UserRepository userRepository = new UserRepository();


            Console.WriteLine("Edit User:");
            Console.Write("Username: ");
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password = Console.ReadLine();
            Console.Write("Full Name: ");
            user.Full_Name = Console.ReadLine();
            Console.Write("Email: ");
            user.Email = Console.ReadLine();

            userRepository.Update(user);
            Console.ReadKey(true);

        }
    }
}
