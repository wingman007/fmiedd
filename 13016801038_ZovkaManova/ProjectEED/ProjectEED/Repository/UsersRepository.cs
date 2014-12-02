using ProjectEED.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEED.Repository
{
    class UsersRepository
    {
         public SqlConnection conn = null;

        public UsersRepository()
        {
            this.conn = new SqlConnection();
            this.conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True";
        }

        public User GetByUserNameandPassword(string username, string password)
        {
            User user = null;


            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[users] WHERE [username]=@username AND [password]=@password";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "username";
            param.Value = username;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "password";
            param.Value = password;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new User();
                    user.ID = (int)reader["id"];
                    user.Firstname = (string)reader["firstname"];
                    user.Lastname = (string)reader["lastname"];
                    user.Username = (string)reader["username"];
                    user.Password = (string)reader["password"];
                    user.Email = (string)reader["email"];
                    user.RoleID = (int)reader["roleid"];
                }
            }
            finally
            {
                conn.Close();
            }
            return user;
        }
        public User GetByID(int id)
        {
            User user = null;


            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[Users] WHERE [id]=@id";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "id";
            param.Value = id;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new User();
                    user.ID = (int)reader["id"];
                    user.Firstname = (string)reader["firstname"];
                    user.Lastname = (string)reader["lastname"];
                    user.Username = (string)reader["username"];
                    user.Password = (string)reader["password"];
                    user.Email = (string)reader["email"];
                    user.RoleID = (int)reader["roleid"];
                }
            }
            finally
            {
                conn.Close();
            }
            return user;
        }
        public List<User> GetAll()
        {

            List<User> result = new List<User>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [users]";

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();

                    user.ID = (int)reader["id"];  
                    user.Firstname = (string)reader["firstname"];
                    user.Lastname = (string)reader["lastname"];
                    user.Username = (string)reader["username"];
                    user.Password = (string)reader["password"];
                    user.Email = (string)reader["email"];
                    user.RoleID = (int)reader["roleid"];
                    result.Add(user);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public void EditUser(User item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            if (item.ID > 0)
            {
                cmd.CommandText = @"
UPDATE users SET
[firstName]=@firstName,
[lastName]=@lastName,
[username]=@username,
[password]=@password,
[email]=@email,
[roleid]=@roleid
WHERE
[id]=@id
";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@firstname";
                param.Value = item.Firstname;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@lastname";
                param.Value = item.Lastname;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@username";
                param.Value = item.Username;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@password";
                param.Value = item.Password;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@email";
                param.Value = item.Email;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@roleid";
                param.Value = item.RoleID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = item.ID;
                cmd.Parameters.Add(param);
            }
            else
            {
                cmd.CommandText = @"
INSERT INTO Users
(
[firstName],
[lastName],
[username],
[password],
[email],
[roleid]
)
VALUES(
@firstName,
@lastName,
@username,
@password,
@email,
@roleid
)";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@firstname";
                param.Value = item.Firstname;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@lastname";
                param.Value = item.Lastname;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@username";
                param.Value = item.Username;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@password";
                param.Value = item.Password;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@email";
                param.Value = item.Email;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@roleid";
                param.Value = item.RoleID;
                cmd.Parameters.Add(param);


            }
            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                this.conn.Close();
            }
        }

        public void Delete(User item)
        {

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
DELETE FROM[Users]
WHERE
id=@id
";
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.ID;
            cmd.Parameters.Add(param);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

    }
     
    }

