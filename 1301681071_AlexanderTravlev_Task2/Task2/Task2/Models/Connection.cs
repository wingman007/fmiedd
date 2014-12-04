using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUD2.Models
{
    public class Connection
    {
        protected SqlConnection conn;
        protected SqlCommand com;
        protected SqlDataReader dreader;

        //methods
        protected void OpenConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=alexander;Integrated Security=True");  // connectionString
                conn.Open();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        protected void CloseConnection()
        {
            try
            {

                conn.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}