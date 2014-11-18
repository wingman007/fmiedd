using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCrudProject.Entity;

namespace ConsoleCrudProject.Repository
{
    public class UsersRepository
    {
        SqlConnection conn = new SqlConnection("Server=COKO-PC\\KITAEC;Database=CRUD;Integrated Security=true"); //Local SQL server
        SqlCommand cmd = new SqlCommand();
        public void Insert(Users users)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "insert into crudProj(id,username,password,email) values ('" + users.Id + "','" + users.username + "','" + users.password + "','" + users.email + "')";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Clone();
            }
            catch (SqlException)
            {
                throw new InvalidOperationException();
            }
            finally
            {
                conn.Close();
            }
        }
        public void Delete(Users users)
        {
            conn.Open();
            cmd.CommandText = "delete from crudProj where id = '" + users.Id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.Clone();
            conn.Close();
        }
        public void Update(Users users)
        {
            conn.Open();
            cmd.CommandText = "update crudProj set username='" + users.username + "',password='" + users.password + "', email='" + users.email + "' where id='" + users.Id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.Clone();
            conn.Close();
        }
        public List<Users> GetAll()
        {
            List<Users> result = new List<Users>();
            conn.Open();
            cmd.CommandText = "SELECT id, username, password, email FROM crudProj";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Users user = new Users();
                user.Id = reader.GetInt32(0);
                user.username = reader.GetString(1);
                user.password = reader.GetString(2);
                user.email = reader.GetString(3);
                result.Add(user);
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
    