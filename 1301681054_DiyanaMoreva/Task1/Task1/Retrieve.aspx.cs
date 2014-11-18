using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1
{
    public partial class Retrieve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void lbInsert_Click(object sender, EventArgs e)
        {
            
            SqlDataSource1.InsertParameters["Username"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtUsername")).Text;
            SqlDataSource1.InsertParameters["Password"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtPassword")).Text;
            SqlDataSource1.InsertParameters["Email"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text;
            SqlDataSource1.Insert();
        }
    }
}