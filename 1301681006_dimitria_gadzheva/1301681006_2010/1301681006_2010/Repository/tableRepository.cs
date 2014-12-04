using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using _1301681006_2010.Tools;
using _1301681006_2010.Repository;
using _1301681006_2010.Service;
using System.Configuration;



namespace _1301681006_2010.View
{
    class tableRepository
    {
       public SqlCeConnection conn=null;

       public tableRepository()
        {
            conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=C:\Users\Dimeto\Source\Repos\fmiedd\1301681006_dimitria_gadzheva\1301681006_2010\1301681006_2010\users.sdf";
        }

       public void Table()
       {
           SqlCeCommand aCommand = conn.CreateCommand();
           aCommand.Connection = conn;
           
           Console.Clear();

           while (true)
           {
               Repository.userRepository.IdentifyUser();

               Menu choice = RenderMenu();

               if (AuthenticationService.LoggedUser.Role.Equals("admin"))
               {
                   switch (choice)
                   {

                       case Menu.Insert:
                           {
                               Add();
                               break;
                           }
                       case Menu.Update:
                           {
                               Update();
                               break;
                           }
                       case Menu.Delete:
                           {
                               Delete();
                               break;
                           }
                       default:
                           {
                               Console.WriteLine("\n Unknown action. \n Press any key to refresh.");
                               Console.ReadKey(true);
                               Console.Clear();
                               Repository.userRepository.IdentifyUser();
                               break;
                           }
                   }
               }
               else
               {
                   switch (choice)
                   {
                       case Menu.memberUpdate:
                           {
                               memberUpdate();
                               break;
                           }
                       default:
                           {
                               Console.WriteLine("\n Unknown action. \n Press any key to refresh.");
                               Console.ReadKey(true);
                               Console.Clear();
                               Repository.userRepository.IdentifyUser();
                               break;
                           }
                   }
               }
           }
       }
        

        private Menu RenderMenu()
        {
            while (true)
            {
                if (AuthenticationService.LoggedUser.Role.Equals("admin"))
                {
                    Console.WriteLine("  controls:     [A]dd       [U]pdate       [D]elete   ");
                    Console.WriteLine(":----------------------------------------------------:");
                    Console.WriteLine("");
                    Console.Write(" Choose contorol: ");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(":----------------------------------------------------:");
                    Console.WriteLine("");
                    Console.Write(" Press [C] to change your info: ");
                }

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {

                    case "A":
                        {
                            return Menu.Insert;
                        }
                    case "U":
                        {
                            return Menu.Update;
                        }
                    case "C":
                        {
                            return Menu.memberUpdate;
                        }
                    case "D":
                        {
                            return Menu.Delete;
                        }
                    
                    default:
                        {
                            Console.WriteLine("\n Unknown action. \n Press any key to refresh.");
                            Console.ReadKey(true);
                            Console.Clear();
                            Repository.userRepository.IdentifyUser();
                            break;
                        }
                }
            }
        }


        public void Add()
        {

            Repository.userRepository.IdentifyUser();      

            Console.WriteLine("                   A D D  U S E R: ");
            Console.WriteLine(":----------------------------------------------------:");

            Console.WriteLine("");
            Console.Write(" id : ");
            string ID = Console.ReadLine();
            int value;
            while (!int.TryParse(ID, out value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Invalid ID.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey(true);
                Console.Clear();
                return;
            };
            
            Console.Write(" Name : ");
            string username = Convert.ToString(Console.ReadLine());

            Console.Write(" Password : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write(" Email : ");
            string email = Convert.ToString(Console.ReadLine());
            
            Console.Write(" Role:");
            string role_id = Convert.ToString(Console.ReadLine());

            SqlCeCommand comm = new SqlCeCommand("select * from users where id = @id", conn);
            SqlCeParameter param = new SqlCeParameter();
            param.ParameterName = "@id";
            param.Value = ID.ToString();
            comm.Parameters.Add(param);
            conn.Open();
            SqlCeDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ID already exists.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey(true);
                Console.Clear();
                reader.Close();
                conn.Close();
                return;
            }
            else
            {
                try
                {
                    SqlCeCommand aCommand = new SqlCeCommand("INSERT INTO [users] ([id], [username], [password], [email], [role_id]) VALUES('" + ID + "','" + username + "','" + password + "','" + email + "','" + role_id + "')", conn);
                    aCommand.ExecuteNonQuery();
                    conn.Close();

                }
                catch (SqlCeException e)
                {
                    Console.WriteLine("Error: {0}", e.Errors[0].Message);
                    conn.Close();
                }
                
                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" User with ID {0} was successfully added to UserTable", ID);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                return;
            }
        }

        public void Update()
        {
            Repository.userRepository.IdentifyUser();     

            Console.WriteLine("                 U P D A T E  U S E R");
            Console.WriteLine(":----------------------------------------------------:");

            Console.WriteLine("");
            Console.Write(" Choose id to be updated: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Name: ");
            string username = Convert.ToString(Console.ReadLine());

            Console.Write(" Password: ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write(" Email: ");
            string email = Convert.ToString(Console.ReadLine());

            Console.Write(" Role:");
            string role_id = Convert.ToString(Console.ReadLine());

            SqlCeCommand comm = new SqlCeCommand("select * from users where id = @id", conn);
            SqlCeParameter param = new SqlCeParameter();
            param.ParameterName = "@id";
            param.Value = ID.ToString();
            comm.Parameters.Add(param);
            conn.Open();
            SqlCeDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {

                try
                {

                    SqlCeCommand aCommand = new SqlCeCommand("UPDATE [users] SET [username]='" + username + "',[password]='" + password + "',[email]='" + email + "',[role_id]='" + role_id + "'where [id]=" + ID, conn);
                    aCommand.ExecuteNonQuery();
                    conn.Close();

                }
                catch (SqlCeException e)
                {
                    Console.WriteLine("Error: {0}", e.Errors[0].Message);
                    conn.Close();
                }


                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" User with ID {0} was successfully updated in UserTable", ID);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ID does not exist.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey(true);
                Console.Clear();
                reader.Close();
                conn.Close();
                return;
            }
        }


        public void memberUpdate()
        {
            Repository.userRepository.IdentifyUser();

            Console.WriteLine("        U P D A T E   I N F O R M A T I O N:");
            Console.WriteLine(":----------------------------------------------------:");
            Console.WriteLine("");

            Console.Write(" Change password: ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write(" Change email: ");
            string email = Convert.ToString(Console.ReadLine());

            SqlCeCommand comm = new SqlCeCommand("select * from users where id=@id", conn);
            comm.Parameters.AddWithValue("@id", AuthenticationService.LoggedUser.Id);
            conn.Open();
            SqlCeDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {                
                try
                {

                    SqlCeCommand aCommand = new SqlCeCommand("UPDATE [users] SET [password]='" + password + "',[email]='" + email + "'where [id]=" + AuthenticationService.LoggedUser.Id, conn);
                    aCommand.ExecuteNonQuery();
                    conn.Close();

                }
                catch (SqlCeException e)
                {
                    Console.WriteLine("Error: {0}", e.Errors[0].Message);
                    conn.Close();
                }


                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Your information was sucessfully updated.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ID does not exist.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey(true);
                Console.Clear();
                reader.Close();
                conn.Close();
                return;
            }

        }



        public void Delete()
        {
            Repository.userRepository.IdentifyUser();     

            Console.WriteLine("               D E L E T E  U S E R");
            Console.WriteLine(":----------------------------------------------------:");

            Console.WriteLine("");
            Console.Write(" Choose ID to be deleted: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            SqlCeCommand comm = new SqlCeCommand("select * from users where id = @id", conn);
            SqlCeParameter param = new SqlCeParameter();
            param.ParameterName = "@id";
            param.Value = ID.ToString();
            comm.Parameters.Add(param);
            conn.Open();
            SqlCeDataReader reader = comm.ExecuteReader();           

            if (reader.Read())
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(" You are about to delete user with ID = {0}. \n Do you want to continue?", ID);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("                [Y]es     [N]o");

                string key = Console.ReadLine();
                if (key == "y" || key == "Y")
                {
                    try
                    {
                        SqlCeCommand aCommand = new SqlCeCommand("DELETE FROM users WHERE id =  " + ID, conn);
                        aCommand.ExecuteNonQuery();
                        reader.Close();
                        conn.Close();

                    }
                    catch (SqlCeException e)
                    {
                        Console.WriteLine("Error: {0}", e.Errors[0].Message);
                        reader.Close();
                        conn.Close();
                    }

                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" User with ID {0} was successfully deleted from UserTable", ID);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");
                    return;

                }
                else
                {
                    Console.Clear();
                    reader.Close();
                    conn.Close();
                    return;
                }

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ID does not exist.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey(true);
                Console.Clear();
                reader.Close();
                conn.Close();
                return;
            }

        }

    }
}
