using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using Ani_Krivova_1301681024_CRUD_Project;
using Ani_Krivova_1301681024_CRUD_Project.Models;

namespace Ani_Krivova_1301681024_CRUD_Project.Controller
{
    public class UserRepository
    {
         OleDbConnection connection = new OleDbConnection(SomeDataInfo.connectionString);

         private void Create(User user)
         {
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand("INSERT INTO Users (FirstName,LastName,Username,'Password') Values (@fname,@lname,@username,@pass) where ID=@userId", connection);
                 command.Parameters.AddWithValue("@userId", user.UserId);
                 command.Parameters.AddWithValue("@fname", user.FirstName);
                 command.Parameters.AddWithValue("@lname", user.LastName);
                 command.Parameters.AddWithValue("@username", user.Username);
                 command.Parameters.AddWithValue("@pass", user.Password);

                 command.ExecuteNonQuery();
                 connection.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }
             

         }

         private User Read(int id)
         {
             User tempuser = new User();
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand("SELECT from Users WHERE ID="+id, connection);
                 OleDbDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     tempuser.FirstName = reader["FirstName"].ToString();
                     tempuser.LastName = reader["LastName"].ToString();
                     tempuser.Username = reader["Username"].ToString();
                     tempuser.Password = reader["Password"].ToString();
                 }
                 reader.Close();
                 connection.Close();

             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }
            
             return tempuser;
         }

         private List<User> ReadAll()
         {
             List<User> tempuserlist = new List<User>();
             User tempuser = new User();
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand("SELECT * from Users", connection);
                 OleDbDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     tempuser.FirstName = reader["FirstName"].ToString();
                     tempuser.LastName = reader["LastName"].ToString();
                     tempuser.Username = reader["Username"].ToString();
                     tempuser.Password = reader["Password"].ToString();
                     tempuserlist.Add(tempuser);
                     Console.WriteLine("***************************************************************");
                 }
                 reader.Close();
                 connection.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }

             return tempuserlist;
         }

         private void Update(User user)
         {
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand("UPDATE Users SET FirstName=@fname,LastName=@lname,Username=@username,Password=@pass WHERE ID=@userId", connection);
                 command.Parameters.AddWithValue("@userId", user.UserId);
                 command.Parameters.AddWithValue("@fname", user.FirstName);
                 command.Parameters.AddWithValue("@lname", user.LastName);
                 command.Parameters.AddWithValue("@username", user.Username);
                 command.Parameters.AddWithValue("@pass", user.Password);

                 command.ExecuteNonQuery();
                 connection.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }
         }

         private void Delete(User user)
         {
             try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand("Delete from Users WHERE userId=@userId", connection);
                 command.Parameters.AddWithValue("@userId", user.UserId);

                 command.ExecuteNonQuery();
                 connection.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }
         }

         public void Save(User item)
         {
             if (item.UserId > 0)
             {
                 Update(item);
             }
             else
             {
                 Create(item);
             }
         }

    }
}