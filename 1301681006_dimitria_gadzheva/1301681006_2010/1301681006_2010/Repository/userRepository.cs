using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1301681006_2010.Entity;
using System.Data.SqlServerCe;
using _1301681006_2010.Service;
using _1301681006_2010.View;
using _1301681006_2010.Tools;

namespace _1301681006_2010.Repository
{
    class userRepository
    {
        static SqlCeConnection conn = null;

         public userRepository()
        {
            conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=C:\Users\Dimeto\Source\Repos\fmiedd\1301681006_dimitria_gadzheva\1301681006_2010\1301681006_2010\users.sdf";
        }
        
        public User GetByUsernameAndPassword(string username, string password)
        {
            SqlCeCommand aCommand = conn.CreateCommand();
            aCommand.Connection = conn;
            aCommand.CommandText = "SELECT * FROM users WHERE username = @username and password = @password";
            aCommand.Parameters.AddWithValue("@username", username);
            aCommand.Parameters.AddWithValue("@password", password);
            conn.Open();
            SqlCeDataReader aReader = aCommand.ExecuteReader();
            try
            {                
                if (aReader.Read()) 
                {
                    User user = new User();
                    user.Id = int.Parse(aReader["id"].ToString());
                    user.Username = username;
                    user.Password = password;
                    return user;
                    
                }
                else //if (aReader["username"].ToString().Trim() == username && aReader["password"].ToString().Trim() == password)
                {
                    return null;
                }
                                              
            }
            catch (SqlCeException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                conn.Close();
            }          
            finally
            {
                aReader.Close();
                conn.Close();
            }

            return null;
        }

        public static void IdentifyUser()
        {
            conn.Close();
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("SELECT roles.role  FROM  roles INNER JOIN  users ON roles.id = users.role_id WHERE (users.username = @username) AND (users.password = @password)", conn);
            cmd.Parameters.AddWithValue("@username", AuthenticationService.LoggedUser.Username);
            cmd.Parameters.AddWithValue("@password", AuthenticationService.LoggedUser.Password);
            SqlCeDataReader aReader = cmd.ExecuteReader();
            try
            {
                if (aReader.Read())
                {
                    AuthenticationService.LoggedUser.Role = aReader["role"].ToString().Trim();                    
                }
                else
                {
                    //AuthenticationService.LoggedUser.Role = "public";
                }

                if (AuthenticationService.LoggedUser.Role.Equals("admin"))
                {
                    Console.Clear();
                    Table adminTable = new Table();
                    adminTable.adminTable();
                }
                else if (AuthenticationService.LoggedUser.Role.Equals("member"))
                {
                    Console.Clear();
                    Table userTable = new Table();
                    userTable.userTable();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("User not found.");
                    return;
                }
            }
            catch (SqlCeException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                conn.Close();
            }
            finally
            {
                aReader.Close();
                conn.Close();
            }                    
        }
    }
}
