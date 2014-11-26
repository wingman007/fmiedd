using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lilyana_Ihtimanska_Task2
{
    public partial class FormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty)
            {
                if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
                {
                    Response.Redirect("FormAdmin.aspx");
                }
                else if (TextBox1.Text == "member" && TextBox2.Text == "member")
                {
                    Response.Redirect("FormMember.aspx");
                }
                else { lblFail.Text = "Invalid Username or Password!"; }
            }
            else { lblFail.Text = "Please enter Username and Password!"; }
        }
    }
}