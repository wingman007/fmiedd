using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUDApp
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["IsAdmin"] == "True")
            {
                LblState.Text = "Wlecome, Your status as Admin is: " + Session["IsAdmin"];
            }
            else
            {
                if ((string)Session["IsAdmin"] == "False")
                {
                    LblState.Text = "Welcome,unfortunately Your status as Admin is:" + Session["IsAdmin"];
                    BtnCreate.Visible = false;
                    BtnDelete.Visible = false;
                    BtnUpdate.Visible = false;
                    BtnPromote.Visible = false;
                }
            }
        }
        protected void BtnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Create.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Update.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Delete.aspx");
        }

        protected void BtnPromote_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Promote.aspx");
        }

        protected void LBLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Authentication.aspx");
        }
    }
}