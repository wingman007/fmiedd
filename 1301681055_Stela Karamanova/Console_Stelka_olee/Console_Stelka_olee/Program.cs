﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Stelka_olee.View;
using System.Data.OleDb;

namespace Console_Stelka_olee
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Login loginView = new Login();
            loginView.Show();

            
            TableView tableView = new TableView();
            tableView.Show();


        
        }
    }
}
