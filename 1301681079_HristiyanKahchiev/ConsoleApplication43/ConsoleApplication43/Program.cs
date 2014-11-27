using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication43
{
    class Program
    {
        static SqlConnection myConnection;
        static void Main(string[] args)
        {

            //1.Creating the Connection
            myConnection =
                new SqlConnection("Data Source=HRISTY-PC;Initial Catalog=Users;Integrated Security=True");
            Console.SetWindowSize(110, 25);
            Console.ResetColor();
            bool loop = true;

            while (loop)
            {
                int choice = GetMenuChoice();
                int id;
                switch (choice)
                {
                    case 1:
                        Retrieve();
                        break;
                    case 2:
                        Console.WriteLine("Please note that the ID must be UNIQUE");
                        Console.ResetColor();
                        Console.Write("Type ID: ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nINVALID OPTION..PLEASE INSERT ID");
                            Console.ResetColor();
                        }
                        string username;
                        Console.Write("Type Username: ");
                        username = Console.ReadLine();
                        string password;
                        Console.Write("Type Password: ");
                        password = Console.ReadLine();
                        string email;
                        Console.Write("Type Email: ");
                        email = Console.ReadLine();
                        Add(ID: id, username: username, password: password, email: email);

                        if (username == "" || password == "")
                        {
                            Console.WriteLine("You have entered an empty Username or Password");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You added new user: {0}", username);
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        Console.Write("Type ID you want to Update: ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("\nINVALID OPTION..PLEASE TYPE AN ID");
                            Console.ResetColor();
                        }
                        Console.Write("Change Username to: ");
                        string updated;
                        updated = Console.ReadLine();
                        Console.Write("Change Password to: ");
                        string updated2;
                        updated2 = Console.ReadLine();
                        Console.Write("Change Email to: ");
                        string updated3;
                        updated3 = Console.ReadLine();
                        Update(ID: id, username: updated, password: updated2, email: updated3);
                        Console.WriteLine("You updated new user: {0} with ID: {1}", updated, id);
                        break;


                    case 4:
                        Console.Write("Type the ID you want to Delete: ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nINVALID OPTION..PLEASE TYPE AN ID");
                            Console.ResetColor();
                        }
                        Delete(ID: id);
                        Console.WriteLine("You Deleted user with ID: {0}", id);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nINVALID OPTION..PLEASE TYPE A NUMBER FROM 1-5");
                        Console.ResetColor();
                        break;
                }
            }

            Console.ReadKey(true);
        }


        public static int GetMenuChoice()
        {
            Console.WriteLine("1. Show Users");
            Console.WriteLine("2. Add a User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Delete User");
            Console.WriteLine("5. Exit");

            Console.Write("Enter from 1 to 5 : ");
            int numChoice;
            while (!int.TryParse(Console.ReadLine(), out numChoice))
            {
                Console.WriteLine("\nINVALID OPTION..PLEASE TYPE A NUMBER FROM 1-5");
            }
            return numChoice;

        }


        public static void Retrieve()
        {
            SqlCommand aCommand = new SqlCommand("SELECT * from users", myConnection);

            // Retrieve
            try
            {
                myConnection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is the returned data from users table");
                Console.ResetColor();
                while (aReader.Read())
                {
                    Console.WriteLine("ID:{0} \tUsername:{1} \t\tPassword:{2}  \t\tEmail:{3}", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3));
                }
                aReader.Close();
                myConnection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
            finally
            {
                myConnection.Close();
            }

        }

        // C- Create
        public static void Add(int ID, string username, string password, string email)
        {
            try
            {
                myConnection.Open();
                SqlCommand aCommand = new SqlCommand("INSERT INTO users (id,username, password, email) VALUES (@id, @username, @password, @email)", myConnection);
                aCommand.Parameters.AddRange(new[] {
                    new SqlParameter("@id",ID),
                    new SqlParameter("@username",username),
                    new SqlParameter("@password",password),
                    new SqlParameter("@email",email)
                });

                int numberOfRows = aCommand.ExecuteNonQuery();
                myConnection.Close();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNumber of records affected {0} from Insert", numberOfRows);
                Console.ResetColor();
            }

            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }

            finally
            {
                myConnection.Close();
            }
        }



        // Update
        public static void Update(int ID, string username, string password, string email)
        {
            try
            {
                myConnection.Open();
                SqlCommand aCommand = new SqlCommand("UPDATE users SET username = @username, password = @password, email = @email WHERE ID = @par1", myConnection);

                aCommand.Parameters.AddRange(new[] {
                    new SqlParameter("@par1", ID),
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@email", email)
                });

                int numberOfRows = aCommand.ExecuteNonQuery();
                myConnection.Close();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNumber of records affected {0} from Update", numberOfRows);
                if (numberOfRows == 0)
                {
                    Console.WriteLine("The ID does not exist!");
                }
                Console.ResetColor();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }

            finally
            {
                myConnection.Close();
            }
        }



        // D - Delete
        public static void Delete(int ID)
        {
            try
            {
                myConnection.Open();
                SqlCommand aCommand = new SqlCommand("DELETE FROM users WHERE ID = @par1", myConnection);

                aCommand.Parameters.AddRange(new[] {
                    new SqlParameter("@par1", ID)
                });
                int numberOfRows = aCommand.ExecuteNonQuery();
                myConnection.Close();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNumber of records affected {0} from Delete", numberOfRows);
                if (numberOfRows == 0)
                {
                    Console.WriteLine("The ID does not exist!");
                }
                Console.ResetColor();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }

            finally
            {
                myConnection.Close();
            }
        }
    }
}
