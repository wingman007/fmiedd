using System;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using ConsolePhonebook.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CRUD.CrudViews
{
    public partial class CreateForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            AuthenticationService authService = (AuthenticationService)Session["authService"];
          //  tbUsername.Text = authService.LoggedUser.Username;

            ContactsRepository contactsRepository = new ContactsRepository();
            ConsolePhonebook.Entity.Contact contact = new ConsolePhonebook.Entity.Contact();
            contact.ParentUserId = authService.LoggedUser.Id;
            contact.FirstName = tbfname.Text;
            contact.LastName = tblname.Text;
            contact.Email = tbemail.Text;

            contactsRepository.Save(contact);

            tbfname.Text = "";
            tblname.Text = "";
            tbemail.Text = "";

        }
    }
}