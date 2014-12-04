using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.Repository;
using projectWeek10.Service;

namespace projectWeek10.View
{
    public class Login
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Username : ");
                string username = Console.ReadLine();

                Console.Write("Password : ");
                string password = Console.ReadLine();

                AuthenticationService.AuthenticateUser(username, password);

                if (AuthenticationService.LoggedUser!= null)
                {
                    Console.WriteLine("Здравейте " + AuthenticationService.LoggedUser.Username);
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.WriteLine("Невалиден Username или Password ! ");
                    Console.ReadKey(true);
                }




            }
        }
    }
}
