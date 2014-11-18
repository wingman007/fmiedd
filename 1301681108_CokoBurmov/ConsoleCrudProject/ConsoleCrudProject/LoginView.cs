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
    public class LoginView
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
                    case UserManagementEnum.Insert:
                        {
                            Add();
                            break;
                        }
                    case UserManagementEnum.Delete:
                        {
                            Delete();
                            break;
                        }
                    case UserManagementEnum.Update:
                        {
                            Update();
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
                Console.WriteLine("Users management: ");
                Console.WriteLine("1.Print all users");
                Console.WriteLine("2.Add user");
                Console.WriteLine("3.Delete user");
                Console.WriteLine("4.Update user");
                Console.WriteLine("5.Close application");
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
                            return UserManagementEnum.Insert;
                        }
                    case "3":
                        {
                            return UserManagementEnum.Delete;
                        }
                    case "5":
                        {
                            return UserManagementEnum.Exit;
                        }
                    case "4":
                        {
                            return UserManagementEnum.Update;
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

        private void Add()
        {
            Console.Clear();

            Users user = new Users();
            UsersRepository creatUser = new UsersRepository();

            Console.WriteLine("Add new User:");
            try
            {
                Console.Write("Id=  ");
                user.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("username=  ");
                user.username = Console.ReadLine();
                Console.Write("password=  ");
                user.password = Console.ReadLine();
                Console.Write("email=  ");
                user.email = Console.ReadLine();
                creatUser.Insert(user);

                Console.WriteLine("User added successfully.");
                Console.ReadKey(true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Id.");
                Console.ReadKey(true);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Already have this ID in DATABASE.");
                Console.ReadKey(true);
            }

        }
        private void Update()
        {
            Console.Clear();

            Users user = new Users();
            UsersRepository updateUser = new UsersRepository();

            Console.WriteLine("Update User:");
            try
            {
                Console.Write("Id=  ");
                user.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("username=  ");
                user.username = Console.ReadLine();
                Console.Write("password=  ");
                user.password = Console.ReadLine();
                Console.Write("email=  ");
                user.email = Console.ReadLine();
                updateUser.Update(user);

                Console.WriteLine("User update successfully.");
                Console.ReadKey(true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Id.");
                Console.ReadKey(true);
            }
        }
        private void Delete()
        {
            Console.Clear();

            Users user = new Users();
            UsersRepository deleteUser = new UsersRepository();

            Console.WriteLine("Delete User: ");
            try
            {
                Console.Write("Id= ");
                user.Id = Convert.ToInt32(Console.ReadLine());
                deleteUser.Delete(user);

                Console.WriteLine("User delete successfully.");
                Console.ReadKey(true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Id.");
                Console.ReadKey(true);
            }
        }
    }
}
