using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace WinFormsCRUD1301681007_attemptOver9000.Service
{
    public class AuthenticationService
    {
        public static bool isLogged = false;

        public static bool isAdmin = false;

        public static string ConnectionString = @"Data Source = data.sdf";

        #region
        public static void GetByUsernameAndPassword(string username, string password)
        {
            SqlCeConnection sqlCeConnection = new SqlCeConnection();
            sqlCeConnection.ConnectionString = ConnectionString;
            try
            {
               

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where username='" + username + "' and password='" + password + "'";
                cmd.Connection = sqlCeConnection;
                sqlCeConnection.Open();

                SqlCeDataAdapter loginUser = new SqlCeDataAdapter(cmd.CommandText, sqlCeConnection);
                DataSet ds = new DataSet();
                loginUser.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    isLogged = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlCeConnection.Close();
            }
        }
        #endregion

        #region
        public static void Insert(string username, string password, string firstName, string lastName, string role)
        {
            SqlCeConnection sqlCeConnection = new SqlCeConnection();
            sqlCeConnection.ConnectionString = ConnectionString;

            Random rnd = new Random();
            int id = rnd.Next(1,1000);

            try
            {
                sqlCeConnection.Open();

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into users values('" + username + "','" + password + "','" + firstName + "','" + lastName + "','" + role + "');";
                cmd.Connection = sqlCeConnection;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlCeConnection.Close();
            }
        }
        #endregion

        #region
        public static void IsAdmin()
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = ConnectionString;

            try
            {
                SqlCeCommand sqlCeCommand = new SqlCeCommand();
                sqlCeCommand.CommandType = System.Data.CommandType.Text;
                sqlCeCommand.CommandText = "select * from users where username='" + frmLogin.loggedUser + "'";
                sqlCeCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlCeDataReader dr = sqlCeCommand.ExecuteReader();
                dr.Read();
                string admin = dr.GetValue(5).ToString();
                if (admin == "Admin" || admin == "admin")
                {
                    isAdmin = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        #endregion

    }
}
