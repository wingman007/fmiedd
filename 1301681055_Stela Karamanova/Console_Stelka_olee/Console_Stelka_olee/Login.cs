﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Stelka_olee.Repository;

namespace Console_Stelka_olee.View
{
    public class Login
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Fname : ");
                string fname = Console.ReadLine();

                Console.Write("Lname : ");
                string lname = Console.ReadLine();

                Console.Write("Password : ");
                string password = Console.ReadLine();

                UserRepository.AuthenticateUser(fname,lname, password);

                if (fname == "users"&& lname =="users")
                {
                    Console.WriteLine("Hi user");
                    Console.ReadKey(true);
                    break;
                }


                Console.ReadKey(true);

            }
        }
    }
}
