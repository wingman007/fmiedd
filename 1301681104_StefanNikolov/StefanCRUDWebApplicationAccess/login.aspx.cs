using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StefanCRUDWebApplicationAccess
{
    public partial class login : System.Web.UI.Page
    {
        //Create Connection String And SQL Statement
        public static OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Stefan\Desktop\1301681104_StefanNikolov\StefanCRUDWebApplicationAccess\database_access\users.accdb");

        public static OleDbCommand myCommand = new OleDbCommand("", myConnection);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enter_btn_Click(object sender, EventArgs e)
        {
            string username = username_box.Text;
            string password = password_box.Text;

            string type_of_user = "";

            string pass_usr = "";

            if (username == "" || password == "")
            {
                error_lbl.Text = "Username and password can not be empty!";
            }
            else
            {

                myConnection.Open();


                OleDbCommand myCommand = new OleDbCommand("select * from users where username = '" + username + "'", myConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                try
                {
                    pass_usr = myReader.GetString(2);
                    type_of_user = myReader.GetString(4);
                }
                catch { error_lbl.Text = "Not existing username!"; }

                myConnection.Close();

                if (password == pass_usr && type_of_user == "Admin")
                {
                    Response.Redirect("index.aspx");
                }
                else if (password == pass_usr && type_of_user == "Regular")
                {
                    Response.Redirect("index_regular.aspx");
                }
                else
                {
                    error_lbl.Text = "Wrong username or password!";
                }

            }
        }
    }
}