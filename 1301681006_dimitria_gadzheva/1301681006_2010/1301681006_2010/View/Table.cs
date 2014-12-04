using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using _1301681006_2010.Service;
using System.Data;
using System.Configuration;


namespace _1301681006_2010.Repository
{
    class Table
    {
        public SqlCeConnection conn = null;

         public Table()
        {
            conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=C:\Users\Dimeto\Source\Repos\fmiedd\1301681006_dimitria_gadzheva\1301681006_2010\1301681006_2010\users.sdf";
        }

        public void adminTable()      
        {
            

            SqlCeCommand aCommand = conn.CreateCommand();
            aCommand.Connection = conn;
            aCommand.CommandText = "SELECT * from users";

            try
            {
                conn.Open();

                SqlCeDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine(":----------------------------------------------------:");
                Console.WriteLine("                 U S E R  T A B L E ");
                Console.WriteLine(":----------------------------------------------------:");
                Console.WriteLine("| id |   Name   |     Password   |        Email      |");
                Console.WriteLine(":----------------------------------------------------:");
                while (aReader.Read())
                {
                    Console.WriteLine("  {0}      {1}       {2}       {3}   ", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3));
                }

                aReader.Close();
                conn.Close();
            }
            catch (SqlCeException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                conn.Close();
            }

            Console.WriteLine(":----------------------------------------------------:");

        }

        public void userTable()
        {            
            SqlCeCommand aCommand = new SqlCeCommand("SELECT * FROM users WHERE username = @username and password = @password", conn);
            aCommand.Parameters.AddWithValue("@username", AuthenticationService.LoggedUser.Username);
            aCommand.Parameters.AddWithValue("@password", AuthenticationService.LoggedUser.Password);
            try
            {
                conn.Open();

                SqlCeDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine(":----------------------------------------------------:");
                Console.WriteLine("                 U S E R  T A B L E ");
                Console.WriteLine(":----------------------------------------------------:");
                Console.WriteLine("| id |   Name   |     Password   |        Email      |");
                Console.WriteLine(":----------------------------------------------------:");
                while (aReader.Read())
                {
                    Console.WriteLine("  {0}      {1}       {2}       {3}  ", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3));
                }

                aReader.Close();
                conn.Close();
            }
            catch (SqlCeException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                conn.Close();
            }

            Console.WriteLine(":----------------------------------------------------:");
        }
    }
    
}
