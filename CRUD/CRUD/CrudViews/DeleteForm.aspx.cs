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
    public partial class DeleteForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbcontactid_TextChanged(object sender, EventArgs e)
        {
            ContactsRepository contactsRepository = new ContactsRepository();
            ConsolePhonebook.Entity.Contact contact = contactsRepository.GetById(Convert.ToInt32(tbcontactid.Text));
            if (contact == null)
            {
                errorlabel.Text = "Contact not found!";
            }
            else
            {
                contactsRepository.Delete(contact);
                errorlabel.Text = "Contact deleted successfully.";
            }

        }
    }
}