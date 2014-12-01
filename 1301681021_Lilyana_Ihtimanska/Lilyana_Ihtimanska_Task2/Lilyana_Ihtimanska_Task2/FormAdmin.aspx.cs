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
    public partial class FormAdmin : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=FMI-532-0\SQLEXPRESS;Initial Catalog=WebApplicationDB;User ID=sa;Password=sa");
        //SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=WebApplicationDB;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        private void Clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            ddList.SelectedValue = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            lblUsername.Text = string.Empty;
            lblPassword.Text = string.Empty;
            lblemail.Text = string.Empty;
            lblrole.Text = string.Empty;
            lblFinish.Text = string.Empty;
            lblInfo.Text = string.Empty;
            lblUser.Visible = true;
            lblname.Visible = true;
            lblPass.Visible = true;
            lblmail.Visible = true;
            lrole.Visible = true;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = @"
Select user_id,username,password,email,role
from Users join Roles
on user_id=role_id";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblId.Text += reader.GetValue(0) + "<br />";
                lblUsername.Text += reader.GetString(1) + "<br />";
                lblPassword.Text += reader.GetString(2) + "<br />";
                lblemail.Text += reader.GetString(3) + "<br />";
                lblrole.Text += reader.GetString(4) + "<br/>";
            }
            reader.Close();
            conn.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Users (user_id,username,password,email) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    lblFinish.Text = "Record inserted! To see the changes, press Show Users!";
                    cmd.CommandText = "insert into roles(role_id,role) values('" + TextBox1.Text + "','" + ddList.SelectedItem + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    Clear();
                }
                catch (Exception ex)
                {
                    lblInfo.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            else { lblFinish.Text = "Can't be inserted!"; }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update Users set username='" + TextBox2.Text + "',password='" + TextBox3.Text + "',email='" + TextBox4.Text + "' where user_id='" + TextBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    lblFinish.Text = "Record updated! To see the changes, press Show Users!";
                    cmd.CommandText = "update roles set role='" + ddList.SelectedItem + "' where role_id='" + TextBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    Clear();
                }
                catch (Exception ex)
                {
                    lblInfo.Text = ex.Message;
                }
                finally { conn.Close(); }
            }
            else { lblFinish.Text = "Can't be updated!"; }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (TextBox1.Text != "")
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from Users where user_id='" + TextBox1.Text + "'";
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    lblFinish.Text = "Record deleted! To see the changes, press Show Users!";
                    Clear();
                }
                catch (Exception ex)
                {
                    lblInfo.Text = ex.Message;
                }
            }
            else { lblFinish.Text = "Can't be deleted!"; }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormLogin.aspx");
        }
    }
}