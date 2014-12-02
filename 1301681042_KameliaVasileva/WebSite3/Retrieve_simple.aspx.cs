using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Retrieve : System.Web.UI.Page
{

    protected void exit_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}