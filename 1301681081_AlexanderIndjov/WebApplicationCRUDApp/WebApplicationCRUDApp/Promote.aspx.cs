using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUDApp
{
    public partial class Promote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPromote_Click(object sender, EventArgs e)
        {
            string str = WebConfigurationManager.ConnectionStrings["ALEXANDERBase1ConnectionString"].ConnectionString;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Users SET RoleID= @RoleID where  @Username=Username and @Password = Password";
                cmd.Parameters.AddWithValue("@RoleID", TxtRole.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPass.Text);
                cmd.Parameters.AddWithValue("@Username", TxtName.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Response.Redirect("~/Authentication.aspx");        
        }
    }
}