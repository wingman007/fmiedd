using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace YaniCRUDWebApplicationSQLCE
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=YANI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("index.aspx");
        }
    }
}