using _1301681006_2010.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1301681006_2010.Service;


namespace _1301681006_2010.View
{
    class Login
    {
        public void SystemLogin()
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine(":----------------------------------:");
                Console.WriteLine("  L O G  I N  T O  C O N T I N U E");

                Console.WriteLine(":----------------------------------:");
                Console.Write("       Enter username: ");
                string username = Console.ReadLine();
                Console.Write("       Enter password: ");
                string password = Console.ReadLine();
                Console.WriteLine(":----------------------------------:");

                AuthenticationService.AuthenticateUser(username, password);

                if (AuthenticationService.LoggedUser != null)
                {
                    Console.WriteLine("   L O G I N  S U C C E S S F U L");                                 
                    Console.WriteLine(":----------------------------------:");
                    Console.WriteLine("");
                    Console.WriteLine("                      Welcome " + AuthenticationService.LoggedUser.Username + ".");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("           I N V A L I D");
                    Console.WriteLine(" U S E R N A M E or P A S S W O R D");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(":----------------------------------:");
                    Console.ReadKey(true);
                    return;
                }              
            }

        }
    }
                
}
