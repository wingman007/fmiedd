﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Stelka_olee.Repository
{
    public class TableRepository
    {
        static OleDbConnection aConnection;
        public static void Table()
        {
            aConnection = new OleDbConnection("Provider=SQLNCLI11;Data Source=STELKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Users");


            OleDbCommand aCommand = new OleDbCommand("SELECT * from users", aConnection);
            try
            {
                aConnection.Open();

                OleDbDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("The returned data from test table");
                while (aReader.Read())
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} ", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3), aReader.GetString(4));
                }

                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("___________________________________________________________________");


        }
    }
}
