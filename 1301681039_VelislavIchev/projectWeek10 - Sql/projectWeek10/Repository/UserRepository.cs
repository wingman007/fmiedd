using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace projectWeek10.Repository
{
    public class UserRepository
    {
        static SqlConnection aConnection;

        public User GetByUsernameAndPassword(string username, string password)
        {
            aConnection = new SqlConnection(@"Data Source=VELKO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=data");
            SqlCommand aCommand = new SqlCommand("SELECT * from users", aConnection);
            try
            {

                aConnection.Open();

                SqlDataReader reader = aCommand.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Id = int.Parse(reader["id"].ToString());
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Email = reader["email"].ToString();
                    user.RoleID = int.Parse(reader["role_id"].ToString());


                    if (user.Username == username && user.Password == password)
                    {
                        return user;
                    }

                }
                return null;

            }
            finally
            {
             
                aConnection.Close();
            }
            
        }


    }
}
