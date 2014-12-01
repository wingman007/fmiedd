using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCrudProject.Entity;
using ConsoleCrudProject.Repository;
using ConsoleCrudProject.Tools;

namespace ConsoleCrudProject.View
{
    public class LoginViewUser
    {
        public void Show()
        {
            while (true)
            {
                UserManagementEnum choice = RenderMenu();
                switch (choice)
                {
                    case UserManagementEnum.Select:
                        {
                            GetAll();
                            break;
                        }
                    case UserManagementEnum.Exit:
                        {
                            return;
                        }
                }
            }
        }
        private UserManagementEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======Logged as user========");
                Console.WriteLine("1.Print all users");
                Console.WriteLine("2.Close application");
                Console.Write("Select an option:");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "1":
                        {
                            return UserManagementEnum.Select;
                        }
                    case "2":
                        {
                            return UserManagementEnum.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Something went wrong");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }
        private void GetAll()
        {
            Console.Clear();
            UsersRepository usersRepository = new UsersRepository();
            List<Users> users = usersRepository.GetAll();

            foreach (Users user in users)
            {
                Console.WriteLine("Id : {0}", user.Id);
                Console.WriteLine("username : {0}", user.username);
                Console.WriteLine("password : {0}", user.password);
                Console.WriteLine("email : {0}", user.email);
                Console.WriteLine("\n\n");

            }

            Console.ReadKey(true);
        }
    }
}
