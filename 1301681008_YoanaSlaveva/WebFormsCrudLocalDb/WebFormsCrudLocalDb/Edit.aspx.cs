using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsCrudLocalDb.Models;

namespace WebFormsCrudLocalDb
{
    public partial class Edit : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)(Session["Role"]) != "admin")
            {
                Response.Redirect("/");
            }

            var User = repo.GetById(Convert.ToInt32(Request.QueryString["id"]));

            this.ID.Value = Request.QueryString["id"];
            string roleId = "";
            
            foreach (var role in repo.getRoles())
            {
                if (User.Role == role.RoleName)
                {
                    roleId = role.Id.ToString();
                }
               
               var item = new ListItem(role.RoleName, role.Id.ToString());               
               this.Roles.Items.Add(item);
                
            }
         
            if (User.Id <= 0)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    TextBoxUsername.Text = User.Username;
                    TextPassword.Text = User.Password;
                    TextEmail.Text = User.Email;
                    this.Roles.SelectedValue = roleId;
                }
            }
        }

        protected void UpdateUser(object sender, EventArgs e)
        {
            
            var User = new User();
            User.Id = Convert.ToInt32(this.ID.Value);
            User.Username = this.TextBoxUsername.Text;
            User.Email = this.TextEmail.Text;
            User.Password = this.TextPassword.Text;
            User.Role = this.Roles.SelectedValue;

            repo.Update(User);
            Response.Redirect("/?ShowMessageUdapte=true");
        }
    }
}
