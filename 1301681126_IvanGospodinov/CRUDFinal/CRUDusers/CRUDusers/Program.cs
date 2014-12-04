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
        public static int role = 0;
        static void Main(string[] args)
        {
            aConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fmi\Source\Repos\fmiedd\1301681126_IvanGospodinov\CRUDFinal\CRUDusers\CRUDusers\data\users.accdb");
            //(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\users.accdb");
               Action(); 
            
        }
        public static bool login(string username, string password) { 
            OleDbCommand selectUser = new OleDbCommand("SELECT COUNT(*) FROM users WHERE username=@username AND password=@password");
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@username", username) });
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@password", password) });
            aConnection.Open();
           
            selectUser.Connection = aConnection;
            try
            {
                int numberOfRows = (int)selectUser.ExecuteScalar();
                if (numberOfRows == 1)
                {
                    aConnection.Close();
                    return true;
                }
                else
                {
                    aConnection.Close();
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            aConnection.Close();
            return false;
        }
        public static void Add(string username, string pass, string email, int role)
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO users (username, [password], email, role) VALUES (@username,@pass,@email,@role)", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@username", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@pass", pass) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@email", email) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@role", role) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("*****Number of rows affected {0} from INSERT*****", numberOfRows);
                Read();
                Console.WriteLine("*****User {0} was successfully inserted!*****",username);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Update(int ID, string username, string pass, string email, int role)
        {
            try
            {
                aConnection.Open();

                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = @par2, [password] = @par3, email = @par4, role = @par5 WHERE ID = @par1", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par2", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par3", pass) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par4", email) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par5", role) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", ID) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("*****Number of rows affected {0} from UPDATE*****", numberOfRows);
                Read();
                Console.WriteLine("*****Number {0} was successfully updaed!*****",ID);
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
                Console.WriteLine("*****Number of rows affected {0} from DELETE*****", numberOfRows);
                Read();
                Console.WriteLine("*****Number {0} was successfully deleted*****",ID);

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
                Console.WriteLine("Users table:");
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
        public static int getRoleKey(string username, string password)
        {
            int role_id = 0;
            aConnection.Open();
            OleDbCommand selectUser = new OleDbCommand("SELECT * FROM users WHERE username=@username AND password=@password", aConnection);
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@username", username) });
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@password", password) });

            OleDbDataReader reader = selectUser.ExecuteReader();
            while (reader.Read())
            {
                role_id = reader.GetInt32(4);
            }

            aConnection.Close();
            return role_id;
        }
        public static void Action()
        {
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            Console.Clear();
            role = getRoleKey(username, password);
            if (login(username, password))
            {
                if (role == 1)
                {
                    Console.WriteLine("*****You are logged in as an ADMINISTRATOR!*****");
                    Read();
                    while (true)
                    {
                        int action = 0;
                        Console.WriteLine("Choose action: 1-Add 2-Update 3-Delete 0-Exit 10-Log out");
                        if (Console.ReadLine() != null)
                        {
                             action = int.Parse(Console.ReadLine());
                        }
                       
                        Console.WriteLine();
                        switch (action)
                        {

                            case 1:
                                Console.WriteLine("Type: user, password, email and role");
                                try
                                {
                                    Console.Write("Enter username: ");
                                    string userAdd = Console.ReadLine();
                                    Console.Write("Enter password: ");
                                    string passAdd = Console.ReadLine();
                                    Console.Write("Enter email: ");
                                    string emailAdd = Console.ReadLine();
                                    Console.Write("Enter role: ");
                                    int roleAdd = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Add(userAdd, passAdd, emailAdd,roleAdd);
                                }
                                catch (Exception e)
                                {
                                   Console.WriteLine(e.Message);
                                }
                                break;

                            case 2:
                                Console.Write("Wich position you want to update? ");
                                try
                                {
                                    int idUpdate = int.Parse(Console.ReadLine());
                                    Console.Write("New username: ");
                                    string usernameUpdate = Console.ReadLine();
                                    Console.Write("New password: ");
                                    string passUpdate = Console.ReadLine();
                                    Console.Write("New email: ");
                                    string emailUpdate = Console.ReadLine();
                                    Console.Write("New role: ");
                                    int roleUpdate = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Update(idUpdate, usernameUpdate, passUpdate, emailUpdate,roleUpdate);
                                }
                                catch (OleDbException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;

                            case 3:
                                Console.WriteLine("Which line do you want to delete? ");
                                try
                                {
                                    int deleteLine = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Delete(deleteLine);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 0:
                                Environment.Exit(0);
                                break;
                            case 10:
                                Console.Clear();
                                Action();
                                break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("*****You are logged in as an USER!*****");
                    Read();
                    Console.WriteLine("0-Exit 1-Log out");
                    int actionUser = int.Parse(Console.ReadLine());
                    switch(actionUser)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Console.Clear();
                            Action();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("*****Wrong username or password!*****");
                Action();
            }
            Console.ReadKey(true);
        }
    }
}
