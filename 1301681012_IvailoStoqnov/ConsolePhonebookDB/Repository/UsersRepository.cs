using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsolePhonebookDB.Entity;
using System.Data.OleDb;

namespace ConsolePhonebookDB.Repository
{
    class UsersRepository
    {
        private OleDbConnection connection = null;

        public UsersRepository()
        {
            this.connection = new OleDbConnection();
            this.connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ivailo\Desktop\ConsolePhonebookDB\ConsolePhonebookDB\Data\Data.mdb";
        }

        public User GetByUsernameAndPassword(User user)
        {
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
SELECT
  ID,
  username, 
  password,
  firstname,
  lastname
FROM
  Users
WHERE
  username = @username 
    and 
  password = @password
";
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);

            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"] != null && reader["password"] != null)
                    {
                        user.ID = Convert.ToInt32(reader["id"]);
                        user.FirstName = Convert.ToString(reader["firstname"]);
                        user.LastName = Convert.ToString(reader["lastname"]);
                        return user;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return null;
        }

        public User AddUser(User user)
        {
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
INSERT INTO Users(
  username,
  password,
  firstname,
  lastname
)
VALUES(
  @username,
  @password,
  @firstname,
  @lastname
)
";
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@firstname", user.FirstName);
            cmd.Parameters.AddWithValue("@lastname", user.LastName);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return GetByUsernameAndPassword(user);
        }

    }
}
