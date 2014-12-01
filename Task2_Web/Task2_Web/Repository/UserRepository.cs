using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Task2_Web.Entity;

namespace Task2_Web.Repository
{
    public class UserRepository
    {
        SqlConnection conn = new SqlConnection("Data Source=DEZARO-PC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void Insert(User user)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Users(id,fname,lname,password) values ('" + user.Id + "','" + user.FirstName + "','" + user.LastName + "','" + user.Password + "')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                cmd.CommandText = "insert into roles(role_id,role) values('" + user.Role_id + "','" + user.Role + "')";
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
        public void Delete(User user)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from Users where id = '" + user.Id + "'";
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
        public void Update(User user)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update Users set fname='" + user.FirstName + "',lname='" + user.LastName + "', password='" + user.Password + "' where id='" + user.Id + "'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                cmd.CommandText = "update roles set role='" + user.Role + "' where role_id='" + user.Role_id + "'";
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
        public List<User> GetAll()
        {
            List<User> result = new List<User>();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = @"
SELECT id, fname, lname, password, role_id, role
from users join roles
on id = role_id  
";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader.GetString(2);
                user.Password = reader.GetString(3);
                user.Role_id = reader.GetInt32(4);
                user.Role = reader.GetString(5);
                result.Add(user);
            }
            reader.Close();
            conn.Close();
            return result;     
        }
        public string GetByUserNammeAndPassword(string name, string password)
        {
            try
            {
                conn.Open();
                cmd.CommandText = @"
SELECT  fname, password, role
from users join roles
on id = role_id  
";
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.FirstName = reader.GetString(0);
                    user.Password = reader.GetString(1);
                    user.Role = reader.GetString(2);
                    if (user.FirstName == name && user.Password == password && user.Role == "admin")
                        return "admin";
                    if (user.FirstName == name && user.Password == password && user.Role == "member")
                        return "member";
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}