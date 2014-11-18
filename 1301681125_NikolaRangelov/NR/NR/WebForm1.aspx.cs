﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NR
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=KOKO-PC\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public static int index;
        private void Clear()
        {
            txtId.Text = string.Empty;
            txtUname.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        private void Load_lsbox()
        {
            conn.Open();
            cmd.CommandText = "SELECT id, username, password, email FROM CRUDUsers";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListBox1.Items.Add(reader.GetInt32(0) + ". " + reader.GetString(1) + " " + reader.GetString(2).ToString() + " " + reader.GetString(3).ToString());
            }
            reader.Close();
            conn.Close();
        }
        private string messLink(string text, bool pro)
        {
            if (pro == true) messBox.ForeColor = Color.Green;
            else messBox.ForeColor = Color.Red;
            return messBox.Text = text;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count == 0)
            {
                lbSelect.Text = "Select for Update or Delete!";
                Load_lsbox();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtUname.Text != string.Empty && txtPassword.Text  != string.Empty && txtEmail.Text != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "insert into CRUDUsers(id,username,password,email) values ('" + txtId.Text + "','" + txtUname.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    conn.Close();
                    Clear();
                    messLink("Create success!", true);
                    ListBox1.Items.Clear();
                    Load_lsbox();
                }
                catch (SqlException)
                {
                    messLink("Can't duplicate or invalid Id!", false);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                messLink("Fail!", false);
                Clear();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                try
                {
                    if (index == Convert.ToInt32(txtId.Text))
                    {
                        conn.Open();
                        cmd.CommandText = "delete from CRUDUsers where id = '" + Convert.ToInt32(txtId.Text) + "'";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        cmd.Clone();
                        conn.Close();
                        Clear();
                        messLink("Delete success!", true);
                        ListBox1.Items.Clear();
                        Load_lsbox();
                    }
                    else messLink("Selected Id is differently from textbox Id!", false);
                }
                catch (FormatException)
                {
                    messLink("Invalid Id!", false);
                }
            }
            else
            {
                messLink("Delete fail!", false);
                Clear();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtUname.Text != string.Empty && txtPassword.Text != string.Empty && txtEmail.Text !=string.Empty)
            {
                try
                {
                    if (index == Convert.ToInt32(txtId.Text))
                    {
                        conn.Open();
                        cmd.CommandText = "update CRUDUsers set username='" + txtUname.Text + "',password='" + txtPassword.Text + "',email='" + txtEmail.Text + "' where id='" + Convert.ToInt32(txtId.Text) + "'";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        cmd.Clone();
                        conn.Close();
                        Clear();
                        messLink("Update success!", true);
                        ListBox1.Items.Clear();
                        Load_lsbox();
                    }
                    else messLink("Can't update Id!", false);
                }
                catch (FormatException)
                {
                    messLink("Invalid Id!!", false);
                }
            }
            else
            {
                messLink("Update Fail!", false);
            }
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "SELECT id, username, password, email FROM CRUDUsers";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (ListBox1.SelectedItem.Text.Substring(0, 3).Contains(reader.GetInt32(0).ToString()))
                {
                    index = reader.GetInt32(0);
                    txtId.Text = reader.GetInt32(0).ToString();
                    txtUname.Text = reader.GetString(1);
                    txtPassword.Text = reader.GetString(2);
                    txtEmail.Text = reader.GetString(3);
                }
            }
            messBox.Text = string.Empty;
            reader.Close();
            conn.Close();
        }
    }
}