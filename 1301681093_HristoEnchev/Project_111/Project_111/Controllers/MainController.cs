using Project_111.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_111.View;
using System.Timers;

namespace Project_111.Controllers
{
    public static class MainController
    {
        
        public static User logUser { get; private set; }
        public static void Check(string username, string password)
        {
            LogCheck check = new LogCheck();

            MainController.logUser = check.CheckUserAndPassword(username, password);

            if (MainController.logUser != null)
            {
                if (logUser.Admin == 1)
                {
                    
                    
                    Console.WriteLine("Hello admin");
                    Console.ReadKey();

                    AdminInfo info = new AdminInfo();
                    info.FullInfo();
                    Actions act = new Actions();
                    act.uAction();
                }
                if (logUser.Admin == 0)
                {
                    
                    Console.WriteLine("Hello {0}", logUser.Username);
                    do
                    {
                        DateTime now = DateTime.Now;
                        Console.Clear();
                       
                        Console.WriteLine("Hello {0}", logUser.Username);
                       
                        Console.WriteLine("");
                        Console.WriteLine("Current time is : {0}", now.ToString());
                        System.Threading.Thread.Sleep(1000);
                   
                    } while (true);

                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong UserName or Password");
                //System.Threading.Thread.Sleep(1500);
                Console.ReadKey(true);
                Console.Clear();
                LoginScreen scr = new LoginScreen();
                scr.LogScreen();


            }
        }
    }
}
