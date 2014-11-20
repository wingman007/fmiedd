using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.Sql;
using System.Data;

namespace Proekt_Osvobojdenie.Connection
{
    class Connect
    {
        private static string ConnectionDBString = @"Data Source=..\..\UsersCE.sdf";
        private static string str = null;

        public static void RegisterME(string usr, string names, string pass, string email)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into UsersCEDB (username,names,password,email,admin) values('"+usr+"','"+names+"','"+pass+"','"+email+"',1);";
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                frmReg.register = "You have been successfully registered, you can login with your username and password!";
            }
            catch (Exception)
            {
                frmReg.register = "Username already exists!";
            }
        }

        public static void ConnectME(string usr, string pass)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from UsersCEDB where username='" + usr + "' and password='" + pass + "'";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCeDataAdapter loginUser = new SqlCeDataAdapter(cmd.CommandText, sqlConnection);
            DataSet ds = new DataSet();
            loginUser.Fill(ds);

            sqlConnection.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                frmLogin.login = 1;
            }
            else
            {
                frmLogin.login = 0;
            }
        }

        public static void IfAdmin(string usr)
        {
            SqlCeConnection conn = new SqlCeConnection();
            SqlCeCommand cmd = new SqlCeCommand();
            conn.ConnectionString = ConnectionDBString;
            cmd = new SqlCeCommand("select * from UsersCEDB where username='" + usr + "'", conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();
            
            rd.Read();
            str = rd.GetValue(4).ToString();
            conn.Close();

            frmLogin.adminlevel = str;
        }
    }
}
