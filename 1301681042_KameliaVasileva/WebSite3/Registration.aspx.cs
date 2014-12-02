using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Camellia.accdb");

    public static OleDbCommand myCommand = new OleDbCommand("", myConnection);

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void submit_btn_Click(object sender, EventArgs e)
    {
        string pass2 = "";

        OleDbCommand myCommand = new OleDbCommand("select * from users where username='" + user_box.Text + "'", myConnection);
        myConnection.Open();
        OleDbDataReader myReader = myCommand.ExecuteReader();
        myReader.Read();
        try
        {
            pass2 = myReader.GetString(2);
        }
        catch
        {
            //nishto za sega
        }
        finally
        {
            myConnection.Close();
        }

        if (user_box.Text == "" || pass_box.Text == "" || email_box.Text == "")
        {
            error_lbl.Text = "Не може да съдържа празни полета!";
        }
        else if(pass_box.Text==pass2)
        {
            error_lbl.Text = "Съществува такъв запис!";
        }
        else
        {
            myConnection.Open();


            OleDbCommand myCommand2 = new OleDbCommand("INSERT INTO users (username,pass,email,type) VALUES ('" + user_box.Text + "','" + pass_box.Text + "','" + email_box.Text + "','" + DropDownList1.SelectedValue.ToString() + "')", myConnection);



            myCommand2.ExecuteNonQuery();

            myConnection.Close();

            Response.Redirect("registration.aspx");
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void del_btn_Click(object sender, EventArgs e)
    {
        if (security_box.Text == "admin")
        {
            int numb = Int32.Parse(DropDownList2.SelectedValue);

            myConnection.Open();

            OleDbCommand myCommand = new OleDbCommand("DELETE FROM users WHERE ID = " + numb + ";", myConnection);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

            Response.Redirect("registration.aspx");
        }
        else
        {
            security_box.Text = "Грешна парола!";
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void security_box_TextChanged(object sender, EventArgs e)
    {

    }
}