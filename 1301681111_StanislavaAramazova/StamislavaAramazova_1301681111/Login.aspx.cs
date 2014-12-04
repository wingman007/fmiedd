using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace StamislavaAramazova1301681111
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Login"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from Users where username = '"+userLogin.Text+"'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (userLogin.Text == "admin" && passLogin.Text == "admin")
            {
                Response.Redirect("index.aspx");
            }
            else if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select password from Users where username = '" + userLogin.Text + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString();
                if (password == passLogin.Text)
                {
                    Session["New"] = userLogin.Text;
                    Response.Redirect("indexMember.aspx");
                }
                else 
                {
                    Response.Write("Data is not correct");
                }                
            }
            else
            {
                Response.Write("Username is not correct");
            }
        }
    }
}