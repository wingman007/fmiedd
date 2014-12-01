using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using Task.Source;

namespace Task.Source
{
    class User_Control
    {
        public static bool DeleteUser(string usr)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            SqlCeCommand sqlCommand = new SqlCeCommand();

            sqlConnection.ConnectionString = Auth.ConnectionDBString;
            sqlCommand = new SqlCeCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "Delete from Users where username='" + usr + "';";
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public static bool editUser(string usrtoedit, string usr, string names, string password, string admin)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            SqlCeCommand sqlCommand = new SqlCeCommand();

            sqlConnection.ConnectionString = Auth.ConnectionDBString;
            sqlCommand = new SqlCeCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "Update Users set username='" + usr + "', names ='" + names + "', password='" + password + "', admin='" + admin + "' where username='" + usrtoedit + "';";
            sqlCommand.Connection = sqlConnection;
            
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
