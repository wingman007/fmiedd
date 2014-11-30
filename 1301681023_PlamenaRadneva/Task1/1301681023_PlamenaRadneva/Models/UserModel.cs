using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BookManager.Models
{
    class UserModel
    {
        static OleDbConnection connenction = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DB\\library.mdb;Persist Security Info=False;");

        public static User LogIn(string username, string password)
        {
            User user = new User();

            string commandtext = "SELECT * FROM users WHERE username = @username AND password = @password";

            OleDbCommand command = new OleDbCommand(commandtext, connenction);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connenction.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user.ID = Convert.ToInt32(dataReader["id"]);
                    user.username = dataReader["username"].ToString();
                    user.password = dataReader["password"].ToString();
                    user.role_id = Convert.ToInt32(dataReader["role_id"]);
                }
                dataReader.Close();
            }

            catch (Exception)
            {}

            finally
            {
                connenction.Close();
            }

            return user;
        }
    }
}
