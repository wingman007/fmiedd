using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using _1301681006_2010.View;
using _1301681006_2010.Repository;




namespace _1301681006_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            Login log = new Login();
            log.SystemLogin();

            tableRepository repo = new tableRepository();
            repo.Table();
                       
            Console.ReadKey(true);
        }
    }
}
