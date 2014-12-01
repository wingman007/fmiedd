using WebFormsCrudLocalDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsCrudLocalDb
{
    public partial class Create : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)(Session["Role"]) != "admin")
            {
                Response.Redirect("/");
            }

                foreach(var role in repo.getRoles())
                {
                    var item = new ListItem(role.RoleName, role.Id.ToString(), true);

                    this.Roles.Items.Add(item);
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var User = new User();
            User.Username = this.TextBoxUsername.Text;
            User.Email = this.TextEmail.Text;
            User.Password = this.TextPassword.Text;
            User.Role = this.Roles.SelectedValue;
            if (repo.Insert(User) == true)
            {
                Response.Redirect("/?ShowMessage=true");
            }
        }
    }
}