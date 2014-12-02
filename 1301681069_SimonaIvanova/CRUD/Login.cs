using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Login
    {
        private string username;
        private string pass;
        private Roles role;
        public void LogIn()
        {
            Console.WriteLine("Enter username");
            username = Console.ReadLine();
            while (username == "")
            {
                Console.WriteLine("user name is empty");
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
            }
            Console.WriteLine("Enter password");
            pass = Console.ReadLine();
            while (pass == "")
            {
                Console.WriteLine("pass is empty");
                Console.WriteLine("Enter password");
                pass = Console.ReadLine();
            }
            role = new Roles(username, pass);
            role.CheckLogInInfo();

            while(!ChekRole(role.role_id))
            {
                Console.Clear();
                Console.WriteLine("Wrong username or password");
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                while (username == "")
                {
                    Console.WriteLine("user name is empty");
                    Console.WriteLine("Enter username");
                    username = Console.ReadLine();
                }
                Console.WriteLine("Enter password");
                pass = Console.ReadLine();
                while (pass == "")
                {
                    Console.WriteLine("pass is empty");
                    Console.WriteLine("Enter password");
                    pass = Console.ReadLine();
                }
                role = new Roles(username, pass);
                role.CheckLogInInfo();
            }

        }
        private bool ChekRole(int role)
        {
            switch(role)
            {
                case 1: AdminView admin = new AdminView(); Console.Clear(); admin.Start(); return true;
                case 2: MemberView member = new MemberView(); Console.Clear(); member.Read(); return true;
                case 3: Console.WriteLine("No info for this role"); return false;
            }
            return false;
        }
    }
}
