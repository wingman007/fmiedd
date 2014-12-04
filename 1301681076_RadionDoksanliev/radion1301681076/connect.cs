using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace radion1301681076
{
    class connect
    {
        private static string ConnectionDBString = @"Data Source=..\..\users.sdf";
        private static string username;
        private static string password;
 

        public static string RegisterME(string usr, string names, string pass, string email)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionDBString;
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into users (username,password,names,email,admin) values('" + usr + "','" + pass + "','" + names + "','" + email + "',1);";
            cmd.Connection = sqlConnection;

            sqlConnection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return "successfuly registered";

                //frmReg.register = "You have been successfully registered, you can login with your username and password!";
            }
            catch (Exception)
            {
                return "username exist";
                //frmReg.register = "Username already exists!";
            }
        }

        public static string connnectMe(string user, string pass)
        {
            SqlCeConnection conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=..\..\users.sdf";
            string sqlQuery = "SELECT * FROM users";
            SqlCeCommand cmd = new SqlCeCommand(sqlQuery, conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                /*
                listboxUsers.Items.Add(rd.GetValue(0).ToString());
                listboxNames.Items.Add(rd.GetValue(1).ToString());
                listboxPass.Items.Add(rd.GetValue(2).ToString());
                listboxEmail.Items.Add(rd.GetValue(3).ToString());*/

                username = rd.GetValue(0).ToString();
                password = rd.GetValue(1).ToString();

            }

            conn.Close();
            if (username == user && password == pass)
            {
                return "success";
            }
            else return "fail";
        }
    }
}
