using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task2_Web.Entity;
using Task2_Web.Repository;
using Task2_Web.Service;

namespace Task2_Web
{
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty)
            {
                AuthenticationService.AuthenticateUser(TextBox1.Text, TextBox2.Text);
                if (AuthenticationService.Logged == "admin")
                    Response.Redirect("fromAdmin.aspx");
                else
                    if (AuthenticationService.Logged == "member")
                    Response.Redirect("formMember.aspx");
                    else lbMess.Text = "Invalid User name or Password!";
            }
            else lbMess.Text = "Invalid User name or Password!";
        }
    }
}