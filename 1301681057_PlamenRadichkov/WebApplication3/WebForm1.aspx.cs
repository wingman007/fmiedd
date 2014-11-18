using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["fname"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtfname")).Text;
            SqlDataSource1.InsertParameters["sname"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtsname")).Text;
            SqlDataSource1.InsertParameters["lname"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtlname")).Text;
            SqlDataSource1.InsertParameters["pol"].DefaultValue = ((DropDownList)GridView1.FooterRow.FindControl("ddlpol")).SelectedValue;
            SqlDataSource1.InsertParameters["email"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtemail")).Text;
            SqlDataSource1.InsertParameters["pass"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtpass")).Text;
            SqlDataSource1.Insert();
        }
    }
}