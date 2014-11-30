using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using WebFormsCrudLocalDb.Models;

namespace WebFormsCrudLocalDb
{
    public partial class Login : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            User user = repo.isValidUser(this.UserName.Text, this.Password.Text);

            if (user.Id != 0)
            {
                Session["Username"] = user.Username;
                Session["Role"] = user.Role;                
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, RememberMe.Checked);
            }

            // If we reach here, the user's credentials were invalid
            InvalidCredentialsMessage.Visible = true;

        }
    }
}