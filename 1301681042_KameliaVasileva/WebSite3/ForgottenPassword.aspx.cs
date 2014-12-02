using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgottenPassword : System.Web.UI.Page
{
    public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Camellia.accdb");

    public static OleDbCommand myCommand = new OleDbCommand("", myConnection);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pass_recovery="";
        string email="";

        OleDbCommand myCommand = new OleDbCommand("select * from users where username='"+username_box.Text+"'",myConnection);
        myConnection.Open();
        OleDbDataReader myReader = myCommand.ExecuteReader();
        myReader.Read();
        try
        {
            email=myReader.GetString(3);
            pass_recovery = myReader.GetString(2);
        }
        catch
        {
            pass_lbl.Text = "Несъщестуваш потребител или грешни данни!";
        }
        finally
        {
            myConnection.Close();
        }

        if(email_box.Text==email)
        {
            pass_lbl.Text = pass_recovery;
        }
        else
        {
            pass_lbl.Text = "Несъщестуваш потребител или грешни данни!";
        }
    }
    protected void back_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}