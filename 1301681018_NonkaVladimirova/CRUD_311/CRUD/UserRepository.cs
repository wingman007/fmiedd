using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    class UserRepository
    {
        private static readonly string dataString = "Server=.\\SQLEXPRESS;Database=users;Trusted_Connection=True;";
        private static SqlConnection conn = null;
        public UserRepository()
        {            
            conn = new SqlConnection(); 
        }
        //Cread
        public void Add(User item)
        {
            SqlCommand cmd = conn.CreateCommand();
            conn.ConnectionString = dataString;
            cmd.CommandText = @"
INSERT INTO users(
  username,
  pass,
  full_name,
  email
)
VALUES (
  @username,
  @pass,
  @full_name, 
  @email
)
";
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = item.Username;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@pass";
            param.Value = item.Password;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@full_name";
            param.Value = item.Full_Name;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@email";
            param.Value = item.Email;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery()>0)
                  Console.WriteLine("User saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //READ
        public List<User> GetAll()
        {
            List<User> result = new List<User>();

            conn.ConnectionString =dataString;
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT
  ID,
  username,
  pass,
  full_name,
  email
FROM
  users
";

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add(new User()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Username = Convert.ToString(reader["username"]),
                        Password = Convert.ToString(reader["pass"]),
                        Full_Name = Convert.ToString(reader["full_name"]),
                        Email = Convert.ToString(reader["email"])
                    });

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message,
                     "Database operation Failed "+ ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        //Update
        public void Update(User item)
        {
            SqlCommand cmd = conn.CreateCommand();
            conn.ConnectionString = dataString;   
                    cmd.CommandText = @"
UPDATE users SET
  pass= @pass,
  full_name= @full_name,
  email= @email
WHERE
  username = @username
";                   
                    SqlParameter param = cmd.CreateParameter();
                    param.ParameterName = "@username";
                    param.Value = item.Username;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@pass";
                    param.Value = item.Password;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@full_name";
                    param.Value = item.Full_Name;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@email";
                    param.Value = item.Email;
                    cmd.Parameters.Add(param);
                
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        Console.WriteLine("User edit successfully.");
                    else Console.WriteLine("User edited successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eror "+ ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        
        }

        //Delete
        public void Delete(string username)
        {
            SqlCommand cmd = conn.CreateCommand();
            conn.ConnectionString = dataString;
            cmd.CommandText = @"
DELETE FROM users
WHERE
  username = @username
";

            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = username;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 0) Console.WriteLine("Delete failed!");
                else Console.WriteLine("User deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        static public void GetRole(User user)
        {
            conn = new SqlConnection();
            conn.ConnectionString = dataString;
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT
  role
FROM
  roles
WHERE 
  ID = @ID
";
            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@ID";
            param.Value = user.ID;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                   {
                       user.Role = Convert.ToString(reader["role"]);
                    };

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message,
                     "Database operation Failed " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        static public User GetByUsernameAndPassword(string username, string password)
        {
            conn = new SqlConnection();

            User loguser = new User();

            SqlCommand cmd = conn.CreateCommand();
            conn.ConnectionString = dataString;   
            cmd.CommandText = @"
SELECT
  ID,
  username,
  full_name,
  email,
  pass
FROM
  users
WHERE
  username = @username
AND
  pass = @pass
";
            SqlParameter param = cmd.CreateParameter();

            param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = username;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@pass";
            param.Value = password;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loguser.ID = Convert.ToInt32(reader["ID"]);
                    loguser.Username = Convert.ToString(reader["username"]);
                    loguser.Full_Name = Convert.ToString(reader["full_name"]);
                    loguser.Email = Convert.ToString(reader["email"]);
                };

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);

            }
            finally
            {
                conn.Close();
            }
            if (loguser.Username == null)
            {
                return null;
            }
            else return loguser;
        }
    }
}
