using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Lilyana_Ihtimanska_Task2
{
    public partial class FormLogin : System.Web.UI.Page
    {
        public void Funkciq() 
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FMI-532-0\SQLEXPRESS;Initial Catalog=WebApplicationDB;User ID=sa;Password=sa");
            //SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=WebApplicationDB;Integrated Security=true");
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
Select username,password,role
from Users join Roles
on user_id=role_id";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) == TextBox1.Text && reader.GetString(1) == TextBox2.Text)
                    {
                        string role = reader.GetString(2);
                        if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty)
                        {
                            if (role == "admin")
                            {
                                Response.Redirect("FormAdmin.aspx");
                            }
                            else if (role == "member")
                            {
                                Response.Redirect("FormMember.aspx");
                            }
                            
                        }
                       // else { lblFail.Text = "Please enter Username and Password!"; }
                    }
                    else { lblFail.Text = "Invalid Username or Password!"; }
                }
                reader.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {
                    lblFail.Text = "Can't read!";
                }
            }
            catch (Exception)
            {
                lblFail.Text = "The connection failed!";
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Funkciq();
        }
    }
}