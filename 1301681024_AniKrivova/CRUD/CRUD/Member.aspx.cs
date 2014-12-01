using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsolePhonebook.Repository;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Service;

namespace CRUD
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblrollename.Text = SiteMaster.rollename;
            if (SiteMaster.rolleId == 1 || SiteMaster.rolleId == 2)
            {
                
            }

            if (SiteMaster.rolleId == 4)
            {
                Create.Enabled = false;
                Update.Enabled = false;
                Delete.Enabled = false;
            }

            
            //AuthenticationService authService = (AuthenticationService)Session["authService"];
            //lblUsername.Text = authService.LoggedUser.Username;
           
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["authService"] = null;
            Response.Redirect("~/Default.aspx");
        }

        //protected void TextBox1_Load(object sender, EventArgs e)
        //{
        //    ContactsRepository contactsRepository = new ContactsRepository();
        //    List<Contact> contacts = contactsRepository.GetAll();
        //}

    }
}