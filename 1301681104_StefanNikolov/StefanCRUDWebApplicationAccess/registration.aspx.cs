using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StefanCRUDWebApplicationAccess
{
    public partial class registration : System.Web.UI.Page
    {
        public static OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Stefan\Desktop\1301681104_StefanNikolov\StefanCRUDWebApplicationAccess\database_access\users.accdb");

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
            else if (pass_box.Text == pass2)
            {
                error_lbl.Text = "Съществува такъв запис!";
            }
            else
            {
                myConnection.Open();


                OleDbCommand myCommand2 = new OleDbCommand("INSERT INTO users (username, password, email, type) VALUES ('" + user_box.Text + "','" + pass_box.Text + "','" + email_box.Text + "','" + DropDownList1.SelectedValue.ToString() + "')", myConnection);



                myCommand2.ExecuteNonQuery();

                myConnection.Close();

                Response.Redirect("registration.aspx");
            }
        }

    }
}