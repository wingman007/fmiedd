using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Lilyana_Ihtimanska_Task2
{
    public partial class FormMember : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=FMI-532-0\SQLEXPRESS;Initial Catalog=WebApplicationDB;User ID=sa;Password=sa");
        //SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=WebApplicationDB;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            lblUsername.Text = string.Empty;
            lblPassword.Text = string.Empty;
            lblemail.Text = string.Empty;
            lblrole.Text = string.Empty;
            lblUser.Visible = true;
            lblname.Visible = true;
            lblPass.Visible = true;
            lblmail.Visible = true;
            lrole.Visible = true;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = @"
Select user_id,username,password,email,role
from Users join Roles
on user_id=role_id";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblId.Text += reader.GetValue(0) + "<br />";
                lblUsername.Text += reader.GetString(1) + "<br />";
                lblPassword.Text += reader.GetString(2) + "<br />";
                lblemail.Text += reader.GetString(3) + "<br />";
                lblrole.Text += reader.GetString(4) + "<br/>";
            }
            reader.Close();
            conn.Close();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormLogin.aspx");
        }
    }
}