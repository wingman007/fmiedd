using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Retrieve : System.Web.UI.Page
{
    public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Camellia.accdb");

    public static OleDbCommand myCommand = new OleDbCommand("", myConnection);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void name_box_TextChanged(object sender, EventArgs e)
    {

    }
    protected void add_btn_Click(object sender, EventArgs e)
    {
        string name2 = "";
        string family2 = "";
        string email2 = "";
        string birthday2 = "";

        OleDbCommand myCommand = new OleDbCommand("select * from adress_book where name='" + name_box.Text+"'", myConnection);
        myConnection.Open();
        OleDbDataReader myReader = myCommand.ExecuteReader();
        myReader.Read();
        try
        {
            family2 = myReader.GetString(2);
            email2 = myReader.GetString(3);
            birthday2 = myReader.GetString(4);
        }
        catch
        {
            //error_lbl.Text = "Записът е добавен!";
        }
        finally
        {
            myConnection.Close();
        }

        if (name_box.Text == "" || family_box.Text == "" || email_box.Text == "" || date_box.Text == "")
        {
            error_lbl.Text = "Не може да съдържа празни полета!";
        }
        else if(family_box.Text==family2&&email_box.Text==email2&&date_box.Text==birthday2)
        {
            error_lbl.Text = "Съществува такъв запис!";
        }  
        else
        {
            myConnection.Open();

            OleDbCommand myCommand2 = new OleDbCommand("INSERT INTO adress_book (name,family,email,Birthday) VALUES ('" + name_box.Text + "','" + family_box.Text + "','" + email_box.Text + "','" + date_box.Text + "')", myConnection);

            myCommand2.ExecuteNonQuery();

            myConnection.Close();

            Response.Redirect("retrieve.aspx");
        }

    }
    protected void update_btn_Click(object sender, EventArgs e)
    {
        if (name_box.Text == "" || family_box.Text == "" || email_box.Text == "" || date_box.Text == "")
        {
            error_lbl.Text = "Не може да съдържа празни полета!";
        }
        else
        {
            myConnection.Open();


            int numb = Int32.Parse(DropDownList1.SelectedValue);



            OleDbCommand myCommand = new OleDbCommand("UPDATE adress_book SET name = '" + name_box.Text + "', family = '" + family_box.Text + "', email = '" + email_box.Text + "', birthday = '" + date_box.Text + "' WHERE ID = " + numb + ";", myConnection);

            myCommand.ExecuteNonQuery();
            myConnection.Close();

            Response.Redirect("retrieve.aspx");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void clear_btn_Click(object sender, EventArgs e)
    {
            myConnection.Open();

            int index = Int32.Parse(DropDownList1.SelectedValue);

            OleDbCommand myCommand = new OleDbCommand("select * from adress_book where id=" + index, myConnection);
            OleDbDataReader myReader = myCommand.ExecuteReader();

            myReader.Read();

            string name = myReader.GetString(1);
            string family = myReader.GetString(2);
            string email = myReader.GetString(3);
            string date = myReader.GetString(4);

            name_box.Text = name;
            family_box.Text = family;
            email_box.Text = email;
            date_box.Text = date;

            myConnection.Close();
    }
    protected void delete_btn_Click(object sender, EventArgs e)
    {
        int numb = Int32.Parse(DropDownList1.SelectedValue);

        myConnection.Open();

        OleDbCommand myCommand = new OleDbCommand("DELETE FROM adress_book WHERE ID = " + numb + ";", myConnection);

        myCommand.ExecuteNonQuery();

        myConnection.Close();

        Response.Redirect("retrieve.aspx");
    }
    protected void submit_btn_Click(object sender, EventArgs e)
    {
    }
    protected void exit_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void izchisti_btn_Click(object sender, EventArgs e)
    {
        name_box.Text = "";
        family_box.Text = "";
        email_box.Text = "";
        date_box.Text = "";
    }
}