using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_111.Model
{
    class LogCheck : Connection
    {
        public User CheckUserAndPassword(string username, string password)
        {

            OleDbCommand command = new OleDbCommand("select * from users", connection);
            try
            {

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                OleDbCommand command1 = new OleDbCommand("select * from Roles", connection);
                OleDbDataReader reader1 = command1.ExecuteReader();
                User user = new User();
                Roles role = new Roles();
                while (reader.Read())
                {
                    user.ID = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                   // user.Admin = reader.GetInt32(4);
                    if (user.Username == username && user.Password == password)
                    {

                        while (reader1.Read())
                        {
                            role.Admin = reader1.GetInt32(2);
                            role.User_ID = reader1.GetInt32(1);
                            if (role.User_ID == user.ID && role.Admin == 1)
                            {
                                user.Admin = 1;
                              
                            }
                            if (role.User_ID == user.ID && role.Admin == 0)
                            {
                                user.Admin = 0;                        
                            }
                        }
                        
                        return user;
                    }
                }
                connection.Close();
                reader.Close();
                reader1.Close();
                
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
            return null;
        }
    }
}
