﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Task1
{
    public partial class WebForm : System.Web.UI.Page
    {
        private string permission_admin;
        SqlConnection con = new SqlConnection(@"Data Source=FMI-532-0\SQLEXPRESS;Database=Project_Users;Persist Security Info=False;User ID=sa;Password=sa;");

        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Insert into Project_Users(ID,Username,Password,Email,Role_id) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+ TextBox5.Text+"')";
            cmd.CommandText = "select * from Project_Users where username='"+Session["username"]+"' and password='"+Session["password"]+"'";
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                permission_admin = rd.GetValue(4).ToString();
            }
            if (permission_admin=="2")
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                Button1.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                //GridView1.Columns[0].Visible = false;
                GridView1.AutoGenerateDeleteButton = false;
                GridView1.AutoGenerateEditButton = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["id"]=TextBox1.Text;
            Session["username"]=TextBox2.Text;
            Session["password"]=TextBox3.Text;
            Session["email"]=TextBox4.Text;
            Session["role_id"]=TextBox5.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Insert into Project_Users(ID,Username,Password,Email,Role_id) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+ TextBox5.Text+"')";
            cmd.CommandText = "Insert into Project_Users(ID,Username,Password,Email,Role_id) values ('" + Session["id"] + "','" + Session["username"] + "','" + Session["password"] + "','" + Session["email"] + "','" + Session["role_id"] + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("WebForm.aspx");
           
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         


         }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginForm.aspx");
        } 
        }
    }
