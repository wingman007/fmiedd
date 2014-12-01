using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SpaceInvader.Models
{
    public class UsersRepository
    {
        private SqlConnection connection = null;

        internal UsersRepository()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }

        public void SaveScore(int score)
        {
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
update Users
set maxscore = @score
where id = @LoggedUserId
";
            
            cmd.Parameters.AddWithValue("@score", score);
            cmd.Parameters.AddWithValue("@LoggedUserId", SecurityService.LoggedUser.Id);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            //catch (Exception) { }
            finally
            {
                this.connection.Close();
            }

        }

        public List<User> GetScore()
        {
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
select top 5 id, username, password, maxscore, rankid
from Users
order by maxscore desc
";
            List<User> result = new List<User>();

            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add(new User() {
                        Id = Convert.ToInt32(reader["id"]),
                        Username = Convert.ToString(reader["username"]),
                        Password = Convert.ToString(reader["password"]),
                        MaxScore = Convert.ToInt32(reader["maxscore"]),
                        Rank = Convert.ToString(reader["rankid"])
                    });
                reader.Close();
            }
            catch(Exception)
            { }
            finally
            {
                this.connection.Close();
            }

            return result;
        }

        public void CreateUser(string username, string password)
        {
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
insert into Users(username, password, rankid)
values(@username, @password, 'ur')
";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) 
            { }
            finally 
            {
                this.connection.Close();
            }
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
SELECT
  id,
  username, 
  password,
  maxscore,
  rankid
FROM
  Users
WHERE
  username = @username 
    and 
  password = @password
";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) return new User()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Username = Convert.ToString(reader["username"]),
                    Password = Convert.ToString(reader["password"]),
                    MaxScore = Convert.ToInt32(reader["maxscore"]),
                    Rank = Convert.ToString(reader["rankid"])
                };
                reader.Close();
            }
            catch (Exception)
            { }
            finally
            {
                this.connection.Close();
            }

            return null;
        }
    }
}
