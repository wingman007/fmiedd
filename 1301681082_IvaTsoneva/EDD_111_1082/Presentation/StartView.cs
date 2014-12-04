using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDD_111_1082.Entity;
using EDD_111_1082.Repository;
using EDD_111_1082.Tools;
using System.Threading;

namespace EDD_111_1082.Presentation
{
    class StartView
    {
        public StartView()
        {
            while (true)
            {
                LoginManagementEnum choice = RenderMenu();
                switch (choice)
                {
                    case LoginManagementEnum.Login:
                        {
                            LoginView laview = new LoginView();
                            if (laview.LoggedUser != null && laview.LoggedUser.Role == "USER" || laview.LoggedUser.Role == "MANAGER")
                            {
                                Thread.Sleep(1500);
                                MailView mview = new MailView(laview.LoggedUser.Username);
                            }
                            else if (laview.LoggedUser.Role  == "ADMIN")
                            {
                                Thread.Sleep(1500);
                                AdminView aview = new AdminView();
                            }
                            
                            break;
                        }
                    case LoginManagementEnum.Register:
                        {
                            RegisterView rview = new RegisterView();
                           if(rview.LoggedUser!=null)
                           {
                               Thread.Sleep(1500);
                               MailView mview = new MailView(rview.LoggedUser);
                           }
                            break;
                        }
                    
                    case LoginManagementEnum.Exit: 
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        private LoginManagementEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("To navigate select 1,2 or 3 and hit ENTER :)");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("C-Mail Menu:");
                Console.WriteLine(" 1. Log-in");
                Console.WriteLine(" 2. Register");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("Your choice:");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            return LoginManagementEnum.Login;
                        }
                    case "2":
                        {
                            return LoginManagementEnum.Register;
                        }
                    case "3":
                        {
                            return LoginManagementEnum.Exit;
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
    }
}
