using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CRUD2.Models;
using CRUD2.Service;

namespace CRUD2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty)
            {
                AuthenticationService.AuthenticateUser(TextBox1.Text, TextBox2.Text);
                if (AuthenticationService.Logged == "admin")
                    Response.Redirect("AdminForm.aspx");
                else
                    if (AuthenticationService.Logged == "member")
                        Response.Redirect("MemberForm.aspx");
                    else lblerror.Text = "Invalid Username or Password!";
            }
            else lblerror.Text = "Invalid Username or Password!";
        }
    }
}