using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDummyAccessConsole
{
    class Program
    {
        static OleDbConnection Connection;
        static void Main(string[] args)
        {
            // 1) establish connection
            Connection =
                new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fmi\\Source\\Repos\\abc\\321312321_StoyanCheresharov\\Task1\\CRUDDummyAccessConsole\\CRUDDummyAccessConsole\\data\\Users.accdb");

            Add();
            Update(4);
            Delete(7);
            // 2) prepare the SQL statement
            OleDbCommand Command = new OleDbCommand("SELECT * from users", Connection);
            try
            {
                Connection.Open();

                OleDbDataReader aReader = Command.ExecuteReader();
                Console.WriteLine("This is the returned data from emp_test table");
                while (aReader.Read())
                {
                    // Console.WriteLine(aReader.GetInt32(0).ToString());
                    // Console.WriteLine(aReader.GetString(1));
                    Console.WriteLine("{0} \t {1}", aReader.GetInt32(0).ToString(), aReader.GetString(1));
                }

                aReader.Close();
                Connection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Add()
        {
            try
            {
                Connection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO Users (username,`password`,email) VALUES ('value1','Password','my@email.com')", Connection);

                aCommand.ExecuteNonQuery();
                Connection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Update(int ID)
        {
            try
            {
                Connection.Open();

                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = 'upadated' WHERE ID = @param1", Connection);

                aCommand.Parameters.AddRange(new[] {
                    new OleDbParameter("@param1", ID)
                });
                aCommand.ExecuteNonQuery();
                Connection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Delete(int ID)
        {
            try
            {
                Connection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE ID = " + ID, Connection);
                aCommand.ExecuteNonQuery();
                Connection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
    }
}
