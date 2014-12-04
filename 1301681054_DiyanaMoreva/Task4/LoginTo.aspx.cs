using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task4
{
    public partial class LoginTo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = (string)(Session["username"]);
            string password = (string)(Session["password"]);

            Button btnLogin = new Button();
            btnLogin.Click += new EventHandler(btnLogin_Click);

            //lblusername.Text = username;
            //lblpassword.Text = password;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["username"] = txtloginusername.Text;
            Session["password"] = txtloginpassword.Text;

            Response.Redirect("Retrieve.aspx");
        }

       
    }
} 