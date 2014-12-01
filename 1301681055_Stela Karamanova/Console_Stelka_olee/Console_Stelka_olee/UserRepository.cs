﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Stelka_olee.View;

namespace Console_Stelka_olee.Repository
{
    public class UserRepository
    {
        public static void AuthenticateUser(string fname,string lname, string password)
        {
            if (fname == "users" && lname=="users" && password == "users")
            {
                Console.WriteLine("Successful Login ! ");

            }
            else
            {
                Console.WriteLine("Wrong fname,lname or password !");
            }

        }
    }
}
