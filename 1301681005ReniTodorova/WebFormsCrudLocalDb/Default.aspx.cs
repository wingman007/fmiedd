using WebFormsCrudAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsCrudAccess
{
    public partial class _Default : Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                LBWelcomeBack.Text = "Добре дошли отново, " + (string)(Session["Username"]) + "!";

                AuthenticatedMessagePanel.Visible = true;
                AnonymousMessagePanel.Visible = false;
            }
            else
            {
                AuthenticatedMessagePanel.Visible = false;
                AnonymousMessagePanel.Visible = true;
            }
        }

        public ICollection<User> GetData()
        {
           return repo.Read();
        }
    }
}