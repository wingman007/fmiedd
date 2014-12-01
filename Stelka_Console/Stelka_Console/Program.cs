using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stelka_Console
{
    class Program
    {
        static OleDbConnection aConnection;
        static void Main(string[] args)
        {

            aConnection =
                new OleDbConnection("Provider=SQLNCLI11;Data Source=STELKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Users");

            Login();
        }
        static void Login()
        {

            Console.Clear();
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Registered");
            Console.WriteLine("2. Not registered");
            Console.WriteLine("3. Exit\n");
            Console.Write("Please tell us if you are already registered or not: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Identification(); break;
                case 2:
                    Insert(); break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nPlease choose a number from 1 to 3!\n");
                    break;
            }


        }


        public static void Menu()
        {
            try
            {
                Read();
                Console.WriteLine("\nPress 1 to UPDATE and 2 to DELETE and 3 to LOGOUT");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("ID of the position you want to update: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("username:");
                            string username = Console.ReadLine();
                            Console.WriteLine("password:");
                            string password = Console.ReadLine();
                            Update(id, username, password);
                            Read();
                        }
                        catch (OleDbException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        Console.Write("ID of the position you want to delete: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());

                            Delete(id);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Login();
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        Console.ReadKey();
                        Menu();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }



        public static void Insert()
        {
            string username = "", lname = "", password = "", email = "";
            int role_id;
            Console.Write("Please type your username: ");
            username = Console.ReadLine();
            Console.Write("Please type your name: ");
            lname = Console.ReadLine();
            Console.Write("Please type your password: ");
            password = Console.ReadLine();
            Console.Write("Please type your email: ");
            email = Console.ReadLine();
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Member");
            Console.WriteLine("2. Admin");
            Console.Write("\nPlease choose your role: ");
            role_id = int.Parse(Console.ReadLine());

            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO users (username, lname, [password], email,role_id) VALUES (?,?,?,?,?)", aConnection);
                aCommand.Parameters.AddWithValue("@fname", username);
                aCommand.Parameters.AddWithValue("@lname", lname);
                aCommand.Parameters.AddWithValue("@password", password);
                aCommand.Parameters.AddWithValue("@email", email);
                aCommand.Parameters.AddWithValue("@role_id", role_id);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added user");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Login();

            }
            catch (OleDbException e)
            {
                aConnection.Close();
                Console.WriteLine("Error: {0}", e.Message);
                Console.ReadKey();
                Login();
            }
        }
        public static void Update(int ID, string username, string password)
        {
            try
            {
                aConnection.Open();

                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = ?, password=? WHERE ID =?", aConnection);
                aCommand.Parameters.AddWithValue("@fname", username);
                aCommand.Parameters.AddWithValue("@lname", password);
                aCommand.Parameters.AddWithValue("@id", ID);
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("\nNumber of rows affected {0} from UPDATE", numberOfRows);
                Console.ReadKey();
                Menu();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                Console.ReadKey();
                Menu();
            }
        }

        public static void Delete(int ID)
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE ID = ?", aConnection);
                aCommand.Parameters.AddWithValue("@asd", ID);
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of rows affected {0} from DELETE", numberOfRows);
                Console.ReadKey();
                Menu();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.StackTrace);
                Console.ReadKey();
                Menu();
            }
        }
        public static void Read()
        {
            try
            {
                Console.Clear();
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("SELECT * from users", aConnection);
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Console.WriteLine("This is the returned data from emp_test table\n \n");
                while (aReader.Read())
                {
                    Console.WriteLine("ID:{0} Username: {1} Name:{2} Password:{3} Email:{4}", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3), aReader.GetString(4));
                    if (aReader.GetInt32(5) == 1)
                    {
                        Console.WriteLine("Role: ADMIN");
                    }
                    else if (aReader.GetInt32(5) == 2)
                    {
                        Console.WriteLine("Role: MEMBER");
                    }
                }

                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }
        }
        public static void Identification()
        {
            string username, password;
            Console.Write("Please type your username: ");
            username = Console.ReadLine();
            Console.Write("Please type your password: ");
            password = Console.ReadLine();

            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("select count(*) from users where username=? and [password]=?", aConnection);
                aCommand.Parameters.AddWithValue("@asd", username);
                aCommand.Parameters.AddWithValue("@pass", password);
                bool exist = (int)aCommand.ExecuteScalar() > 0;

                if (exist)
                {
                    aConnection.Close();
                    Console.WriteLine("User exist .. press any key to continue ..");
                    Console.ReadKey();
                    Menu();
                }
                else
                {
                    aConnection.Close();
                    Console.WriteLine("User doesn't exist!");
                    Console.ReadKey();
                    Login();
                }


            }
            catch (Exception e)
            {
                aConnection.Close();
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Login();
            }





        }
    }
}




