using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Camellia.accdb");

    public static OleDbCommand myCommand = new OleDbCommand("", myConnection);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void enter_btn_Click(object sender, EventArgs e)
    {
        string username = username_box.Text;
        string password = password_box.Text;

        string type_of_user = "";

        string pass_usr="";

        if (username == "" || password == "")
        {
            error_lbl.Text = "Потребителското име и/или паролата не може да са празни!";
        }
        else
        {

            myConnection.Open();


            OleDbCommand myCommand = new OleDbCommand("select * from users where username = '" + username + "'", myConnection);
            OleDbDataReader myReader = myCommand.ExecuteReader();
            myReader.Read();
            try { pass_usr = myReader.GetString(2);
            type_of_user = myReader.GetString(4);
            }
            catch { error_lbl.Text = "Несъщесвуващ потребител!"; }
            
            myConnection.Close();

            if (password == pass_usr && type_of_user=="Admin")
            {
                Response.Redirect("retrieve.aspx");
            }
            else if (password == pass_usr && type_of_user == "Regular")
            {
                Response.Redirect("retrieve_simple.aspx");
            }
            else
            {
                error_lbl.Text = "Грешно потребителско име/парола!";
            }

        }
    }
    protected void reg_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
    protected void pass_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("ForgottenPassword.aspx");
    }
    protected void password_box_TextChanged(object sender, EventArgs e)
    {

    }
}