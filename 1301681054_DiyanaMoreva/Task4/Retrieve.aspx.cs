using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task4
{
    public partial class Retrieve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button btnInsert = new Button();
            //btnInsert.Click += new EventHandler(btnInsert_Click);
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //SqlDataSource1.InsertParameters["username"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtUsername")).Text;
            //SqlDataSource1.InsertParameters["password"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtPassword")).Text;
            //SqlDataSource1.InsertParameters["email"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text;
           //"INSERT INTO [Users] ([ID], [username], [password], [email], [role_id]) VALUES ('"+ Session["ID"] + "','"+ Session["username"] +"','"+ Session["password"] +"','"+ Session["email"] +"','"+ Session["role_id"] +"')";
            SqlDataSource1.Insert();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginTo.aspx");
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtRoleid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}