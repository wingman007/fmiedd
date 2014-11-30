using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Task1
{
    public partial class LoginForm : System.Web.UI.Page
    {
        //private string username;
        //private string password;
        
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=Project_Users;Persist Security Info=False;User ID=sa;Password=LitoMed123;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //username = TextBox1.Text;
            //password = TextBox2.Text;
            Session["username"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from Project_Users where username='"+ TextBox1.Text+"' and password='"+ TextBox2.Text+"'";
            cmd.CommandText = "Select * from Project_Users where username='" + Session["username"] + "' and password='" + Session["password"] + "'";
            cmd.ExecuteNonQuery();
            
          

            con.Close();
            SqlDataAdapter loginUser = new SqlDataAdapter(cmd.CommandText, con);
            DataSet ds = new DataSet();
            loginUser.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Redirect("WebForm.aspx");
            }
            else
            {
                Label3.Text="ERROR";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}