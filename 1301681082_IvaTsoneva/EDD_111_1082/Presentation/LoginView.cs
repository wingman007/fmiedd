using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDD_111_1082.Entity;
using EDD_111_1082.Repository;
using System.Threading;

namespace EDD_111_1082.Presentation
{
    class LoginView
    {
        public User LoggedUser { get; private set; }
        public LoginView()
        {
            LoggedUser = Login();

        }
        private User Login()
        {
            User s_logged = null;
            while (true)
            {
                Console.Clear();
                AutenticationRepository arepo = new AutenticationRepository();
                User user1 = new User();

                Console.WriteLine("Username:");
                user1.Username = Console.ReadLine();
                Console.WriteLine("Password:");
                user1.Password = Console.ReadLine();
                try
                {
                    User returnedUser = arepo.Login(user1.Username, user1.Password);

                    if (returnedUser != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome {0} !", returnedUser.Firstname);
                        s_logged = returnedUser;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username or password!");
                        Thread.Sleep(1000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1000);
                    Console.ReadKey(true);
                }
            }
            return s_logged;
        }
    }
}
