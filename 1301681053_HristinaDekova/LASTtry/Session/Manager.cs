using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Domain;
using System.Data;
using System.Threading.Tasks;


namespace Session
{
    public class Manager
    {
        OleDbConnection con;
        OleDbCommand command;
        private object UserName;
        private object Password;
        private object Email;
        

        private void ConnectTo()
        { //D:\\LastTry\\LASTtry
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\LastTry\\LASTtry\\Database.accdb");
            command = con.CreateCommand();
        }
        public Manager()
        {
            ConnectTo();
        }
        public void Insert(Users u)
        {
            try
            {

                command.CommandText = "INSERT INTO Tusers (UserName, [Password], Email) VALUES ('" + u.UserName + "','" + u.Password + "','" + u.Email + "');";
                command.CommandType = CommandType.Text;
                
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                con.Open();
                
                command.ExecuteNonQuery();
                
            }
            catch (Exception )
            {
                
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<Users> FillComboBox()
        {
            List<Users> usersList = new List<Users>();
            try
            {
                command.CommandText = "SELECT * FROM Tusers";
                command.CommandType = CommandType.Text;
                con.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users u = new Users();
                    u.Id = Convert.ToInt32(reader["ID"].ToString());
                    u.UserName = reader["Username"].ToString();
                    u.Password = reader["Password"].ToString();
                    u.Email = reader["Email"].ToString();

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
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        public void Update(Users OldUsers, Users NewUsers)
        {
            try
            {
                command.CommandText = "UPDATE Tusers SET UserName = '"+NewUsers.UserName+"', [Password] ='"+NewUsers.Password+" ',Email ='"+NewUsers.Email+"'Where Id ="+OldUsers.Id;
                command.CommandType = CommandType.Text;
                con.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();

                }
            }
        }

        public void Delete(Users u)
        {
            try
            {
                command.CommandText = "DELETE FROM Tusers WHERE ID ="+u.Id;
                command.CommandType = CommandType.Text;
                con.Open();

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();

                }
            }
        }


    }
}