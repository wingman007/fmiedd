using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebFormsCrudAccess.Models
{
    public class UserRepository
    {
        public UserRepository()
        {
            conn = getConnectionString();
        }

        public IDbConnection conn;
        public IDbConnection getConnectionString()
        {
            ConnectionStringSettings cm = ConfigurationManager.ConnectionStrings["myConnection"];
            IDbConnection Conn = new OleDbConnection(cm.ConnectionString);
            return Conn;
        }

        public bool Insert(User u)
        {            
            try
            {
                using (IDbConnection connection = getConnectionString())
                {
                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO [user] ([username], [password], [email],[roleId]) VALUES (@username, @password,@email,@role)";

                         IDataParameter param = command.CreateParameter();

                        param.ParameterName = "username";
                        param.Value = u.Username;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "password";
                        param.Value = u.Password;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "email";
                        param.Value = u.Email;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "roleId";
                        param.Value = u.Role;
                        command.Parameters.Add(param);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }

            catch (Exception e)
            {
                e.Message.ToString();
            }
            return false;
        }


        public List<User> Read()
        {
            List<User> result = new List<User>();

            try
            {
                using (IDbConnection connection = conn)
                {
                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                       
                        command.CommandText = "SELECT User.[ID], [User].username, [User].password, [User].email, Roles.[role] FROM [User] INNER JOIN [Roles] ON [User].roleId = [Roles].id";
                        IDataReader reader = null;
                        reader = command.ExecuteReader();                       
                        while (reader.Read())
                        {
                            var user = new User();
                            user.Id = reader.GetInt32(0);
                            user.Username = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            user.Email = reader.GetString(3);
                            user.Role = reader.GetString(4);

                            result.Add(user);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return result;
        }

        public User GetById(int id)
        {
            var user = new User();
            using (IDbConnection connection = conn)
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [id], [username], [password], [email] FROM [User] WHERE [id] = @id";

                    IDataParameter param = command.CreateParameter();

                    param.ParameterName = "id";
                    param.Value = id;
                    command.Parameters.Add(param);

                    IDataReader reader = null;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Email = reader.GetString(3);
                    }
                }
            }
            return user;
        }

        public void Update(User u)
        {
            try
            {
                using (IDbConnection connection = getConnectionString())
                {

                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        
                        command.CommandText = "UPDATE [user] SET [username] = @username, [password] = @password, [email] = @email  WHERE [id] =  @id";

                      
                        IDataParameter param;

                        param = command.CreateParameter();
                        param.ParameterName = "username";
                        param.Value = u.Username;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "password";
                        param.Value = u.Password;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "email";
                        param.Value = u.Email;
                        command.Parameters.Add(param);

                        param = command.CreateParameter();
                        param.ParameterName = "id";
                        param.Value = u.Id;
                        command.Parameters.Add(param);
                      
                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception e)
            {
                e.Message.ToString();
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (IDbConnection connection = getConnectionString())
                {
                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM [User] WHERE [id] = @id";
                        IDataParameter param;

                        param = command.CreateParameter();
                        param.ParameterName = "id";
                        param.Value = id;
                        command.Parameters.Add(param);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }

        }
        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = new User();
            using (IDbConnection connection = conn)
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT User.[ID], [User].username, [User].password, [User].email, Roles.[role] FROM [User] INNER JOIN [Roles] ON [User].roleId = [Roles].id  WHERE [User].username = @username AND [User].password = @password";
                    
                    IDataParameter param;
                    param = command.CreateParameter();
                    param.ParameterName="username";
                    param.Value=username;
                    command.Parameters.Add(param);

                    param = command.CreateParameter();
                    param.ParameterName="password";
                    param.Value=password;
                    command.Parameters.Add(param);

                   using(IDataReader reader =  command.ExecuteReader())
                   {
                      while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Email = reader.GetString(3);
                        user.Role = reader.GetString(4);
                    }
                   }
                }
            }
            return user;
        }
        public List<Role> getRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                using (IDbConnection connection = getConnectionString())
                {
                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT [id], [role] FROM Role";
                        IDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var role = new Role();
                            role.Id = reader.GetInt32(0);
                            role.RoleName = reader.GetString(1);
                            roles.Add(role);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return roles;
        }
    }
}
