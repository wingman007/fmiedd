using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Domain;
using System.Data;

namespace Session
{
    public class Manager
    {
        OleDbConnection OleDBConnection;
        OleDbCommand command;
       /* private object UserName;
        private object Password;
        private object Email;*/  

        private void ConnectTo()
        {
            OleDBConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\Documents\\Visual Studio 2012\\Projects\\AccessWinFormApplication - CRUD\\AccessWinFormApplication - CRUD\\data\\Database1.accdb");
            command = OleDBConnection.CreateCommand();
        }
        public Manager()
        {
            ConnectTo();
        }

        public List<Users> FillComboBox()
        {
            List<Users> usersList = new List<Users>();
            try
            {
                OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\Documents\\Visual Studio 2012\\Projects\\AccessWinFormApplication - CRUD\\AccessWinFormApplication - CRUD\\data\\Database1.accdb");
                myConnection.Open();
                command.CommandText = "SELECT * FROM [User]";
                command.CommandType = CommandType.Text;
                OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE ID=3", myConnection); 
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    Users u = new Users();
                    u.Id = Convert.ToInt32(reader["ID"].ToString());
                    u.UserName = reader["Username"].ToString();
                    u.Password = reader["Password"].ToString();
                    u.Email = reader["E-mail"].ToString();

                    usersList.Add(u);
                }
                return usersList;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (OleDBConnection != null)
                {
                    OleDBConnection.Close();
                }
            }
        }


        public void Insert(Users u)
        {
            try
            {

                command.CommandText =@"INSERT INTO [User] ([UserName], [Password], [E-mail]) VALUES (@username,@passwordd,@email)";
                command.Parameters.AddWithValue("@username", u.UserName);
                command.Parameters.AddWithValue("@passwordd", u.Password);
                command.Parameters.AddWithValue("@email", u.Email);
                command.CommandType = CommandType.Text;
                
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                OleDBConnection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (OleDBConnection != null)
                {
                    OleDBConnection.Close();
                }
            }
        }

        public void Update(Users OldUsers, Users NewUsers)
        {
            try
            {
                command.CommandText = "UPDATE [User] SET UserName = '" + NewUsers.UserName + "', [Passwordd] ='" + NewUsers.Password + " ',Email ='" + NewUsers.Email + "'Where Id =" + OldUsers.Id;
                command.CommandType = CommandType.Text;
                OleDBConnection.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (OleDBConnection != null)
                {
                    OleDBConnection.Close();

                }
            }
        }

        public void Delete(Users u)
        {
            try
            {
                command.CommandText = "DELETE FROM [User] WHERE ID =" + u.Id;
                command.CommandType = CommandType.Text;
                OleDBConnection.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (OleDBConnection != null)
                {
                    OleDBConnection.Close();

                }
            }
        }
    }
}
