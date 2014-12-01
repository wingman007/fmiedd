using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace Task.Source
{
    class Auth
    {
        public static string ConnectionDBString = @"Data Source=..\..\UsersDB.sdf";

        public static bool RegisterNewUser(string usr, string names, string pass)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Users values('" + usr + "','" + names + "','" + pass + "','Admin');";
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ConnectUser(string usr, string pass)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Users where username='" + usr + "' and password='" + pass + "'";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCeDataAdapter loginUser = new SqlCeDataAdapter(cmd.CommandText, sqlConnection);
            DataSet ds = new DataSet();
            loginUser.Fill(ds);

           if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool LoggedUserCheckPermission()
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;

            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Users where username='" + frmLogin.loggedUser + "'";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlCeDataReader rd = sqlCommand.ExecuteReader();
            rd.Read();
            if (rd.GetValue(3).ToString() == "Admin")
            {
                return true;
            }
            else return false;
            rd.Close();
            sqlConnection.Close();
        }
    }
}
