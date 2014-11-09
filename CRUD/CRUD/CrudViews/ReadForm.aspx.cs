using ConsolePhonebook.Repository;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.CrudViews
{
    public partial class ReadForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ContactsRepository contactsRepository = new ContactsRepository();
            List<ConsolePhonebook.Entity.Contact> contacts = contactsRepository.GetAll(1);

            foreach (ConsolePhonebook.Entity.Contact c in contacts)
            {
                readdata.Text +="ID: "+ c.Id + "\n";
                readdata.Text +="Name: "+ c.FirstName +"  "+c.LastName + "\n";
                readdata.Text +="Email: "+  c.Email + "\n";
                readdata.Text += "\n";
                readdata.Text += "*********************************************************" + "\n";
                readdata.Text += "\n";
            }
        }
    }
}