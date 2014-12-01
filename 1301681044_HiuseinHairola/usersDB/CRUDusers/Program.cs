using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDusers
{
    class Program
    {
        static OleDbConnection aConnection;
        static void Main(string[] args)
        {
            aConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Users\\ivan\\Desktop\\usersDB\\CRUDusers\\data\\users.accdb");
            Read();
            while (true)
            {
                Console.WriteLine("Press 1 to ADD new, 2 to UPDATE and 3 to DELETE");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("username:");
                            string user = Console.ReadLine();
                            Console.WriteLine("password:");
                            string pass = Console.ReadLine();
                            Console.WriteLine("email:");
                            string email = Console.ReadLine();
                            Add(user, pass, email);
                            Read();
                        }
                        catch(OleDbException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("ID of the position you want to update: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Username:");
                            string username = Console.ReadLine();
                            Update(id, username);
                            Read();
                        }
                        catch (OleDbException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("ID of the position you want to delete: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Delete(id);
                            Read();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }

            }
        }

        public static void Add(string username, string password, string email)
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO users (username, [password], email) VALUES (@par1,@par2,@par3)", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par2", password) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par3", email) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Update(int ID, string username)
        {
            try
            {
                aConnection.Open();

                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = @par2 WHERE ID = @par1", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par2", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", ID) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of rows affected {0} from UPDATE", numberOfRows);
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
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE ID = @par1", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", ID) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of rows affected {0} from DELETE", numberOfRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);

            }

        }
        public static void Read()
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("SELECT * from users", aConnection);
                OleDbDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("Users in database:");
                while (aReader.Read())
                {
                    Console.WriteLine("{0} \t {1}", aReader.GetInt32(0).ToString(), aReader.GetString(1));
                }
                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
    }
}
