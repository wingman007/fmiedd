using ConsolePhonebook.Repository;
using ConsolePhonebook.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.CrudViews
{
    public partial class UpdateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbcontactid_TextChanged(object sender, EventArgs e)
        {
            if (tbcontactid != null)
            {
                lblError.Visible = false;
                UpdatePanel.Visible = true;
            }
            else { lblError.Visible = true; }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ContactsRepository contactsRepository = new ContactsRepository();
            ConsolePhonebook.Entity.Contact contact = contactsRepository.GetById(Convert.ToInt32(tbcontactid.Text));

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