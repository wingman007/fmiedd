using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsCrudAccess.Models;

namespace WebFormsCrudAccess
{
    public partial class Login : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbuser.Text;
            user.Password = tbpass.Text;

            Session[user.Username]=tbuser.Text;
            Session[user.Password] = tbpass.Text;
        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            User user = repo.GetByUsernameAndPassword(this.tbuser.Text, this.tbpass.Text);

            if (user.Id != 0)
            {
                Session["Username"] = user.Username;
                Session["Role"] = user.Role;
                FormsAuthentication.RedirectFromLoginPage(tbuser.Text, cbRememberMe.Checked);
            }

            lbError.Visible = true;
        }
    }
}