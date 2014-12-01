using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet1.Tablic' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'bazaDataSet.Tablic' table. You can move, or remove it, as needed.
           

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection mysqlcon  = new SqlConnection(@"Server=FMI-532-0\SQLEXPRESS;Initial Catalog=WebApplicationDB;User ID=sa;Password=sa");
            mysqlcon.Open();

            while (tbID.Text != "" && tbUsername.Text != "" && tbPassword.Text != "" && tbEmail.Text != "")
            {
                SqlCommand mysqlcom = new SqlCommand("INSERT INTO [baza].[dbo].[Tablic] (ID, USERNAME, PASSWORD, EMAIL)" + "VALUES(@ID, @USERNAME, @PASSWORD, @EMAIL)", mysqlcon);


                mysqlcom.Parameters.Add("@ID", tbID.Text);
                mysqlcom.Parameters.Add("@Username", tbUsername.Text);
                mysqlcom.Parameters.Add("@Password", tbPassword.Text);
                mysqlcom.Parameters.Add("@Email", tbEmail.Text);



                SqlDataReader mysqldr = mysqlcom.ExecuteReader();

                while (mysqldr.Read())
                {
                    Console.WriteLine("{0}" + tbID.Text + "{1}" + tbUsername.Text + "{2}" + tbPassword.Text + "{3}" + tbEmail.Text, mysqldr.GetSqlValue(0), mysqldr.GetSqlString(1), mysqldr.GetSqlValue(2), mysqldr.GetString(3));
                }


                label1.Text = "You inserted a new row!";


                mysqldr.Close();
                mysqlcon.Close();

            }

            if (tbID.Text == "")
            {
                MessageBox.Show("You must to enter your id!");
            }

            else
                if (tbUsername.Text == "")
                {
                    MessageBox.Show("You must to enter your username!");
                }

                else
                    if (tbUsername.Text.Contains('@') || tbUsername.Text.Contains('#') || tbUsername.Text.Contains('!')
                         || tbUsername.Text.Contains('$') || tbUsername.Text.Contains('%') || tbUsername.Text.Contains('*'))
                    {
                        MessageBox.Show("This username is incorrect! Please enter a correct username!");
                    }

                    else
                        if (tbPassword.Text == "")
                        {
                            MessageBox.Show("You must to enter your password!");
                        }

                        else
                            if (tbPassword.Text.Contains('@') || tbPassword.Text.Contains('#') || tbPassword.Text.Contains('!')
                                || tbPassword.Text.Contains('$') || tbPassword.Text.Contains('%') || tbPassword.Text.Contains('*'))
                            {
                                MessageBox.Show("Your password is incorrect! Please enter a correct password!");
                            }

                            else
                                if (tbEmail.Text == "")
                                {
                                    MessageBox.Show("You must to enter your email!");
                                }
                        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection mythirdsqlcon = new SqlConnection("Server=USER-PC\\SQLEXPRESS; Database=Baza; Integrated Security=true; Persist Security Info=false;");
            mythirdsqlcon.Open();


            SqlCommand mythirdsqlcommand = new SqlCommand("UPDATE [].[baza].[dbo].[Tablic]" + "SET Password='boyzone'" + "WHERE USERNAME=@USERNAME", mythirdsqlcon);
            mythirdsqlcommand.Parameters.Add("@USERNAME", tbUsername.Text);


            SqlDataReader mythirdsqldr = mythirdsqlcommand.ExecuteReader();
            

            while (mythirdsqldr.Read())
            {

                Console.WriteLine("{0}" + tbID.Text + "{1}" + tbUsername.Text + "{2}" + tbPassword.Text + "{3}" + tbEmail.Text, mythirdsqldr.GetSqlValue(0), mythirdsqldr.GetSqlString(1), mythirdsqldr.GetSqlValue(2), mythirdsqldr.GetString(3));
            }

            label1.Text = "You updated a column!";

            mythirdsqldr.Close();
            mythirdsqlcon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection mysecondsqlcon = new SqlConnection("Server=USER-PC\\SQLEXPRESS; Database=Baza; Integrated Security=true; Persist Security Info=false;");
            mysecondsqlcon.Open();


            SqlCommand mysecondsqlcommand = new SqlCommand("DELETE " + "FROM [baza].[dbo].[Tablic]" + "WHERE ID=@ID", mysecondsqlcon);
            mysecondsqlcommand.Parameters.Add("@ID", tbID.Text);


            SqlDataReader mysecondsqldr = mysecondsqlcommand.ExecuteReader();

            while (mysecondsqldr.Read())
            {
                Console.WriteLine("{0}" + tbID.Text + "{1}" + tbUsername.Text + "{2}" + tbPassword.Text + "{3}" + tbEmail.Text, mysecondsqldr.GetSqlValue(0), mysecondsqldr.GetSqlString(1), mysecondsqldr.GetSqlValue(2), mysecondsqldr.GetString(3));
            }


            label1.Text = "You deleted a row!";

            mysecondsqldr.Close();
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
           if (usernameTb.Text != "" && passwordTb.Text != "" && rbArministrator.Checked==true)
           {
               usernameTb.Visible = false;
               passwordTb.Visible = false;
               rbUser.Visible = false;
               rbArministrator.Visible = false;
               usernameLb.Visible = false;
               passwordLb.Visible = false;
               roleLb.Visible = false;
               btnSingIn.Visible = false;
               tbID.Visible = true;
               tbUsername.Visible = true;
               tbPassword.Visible = true;
               tbEmail.Visible = true;
               btnInsert.Visible = true;
               btnDelete.Visible = true;
               btnUpdate.Visible = true;
               lbID.Visible = true;
               lbUsername.Visible = true;
               lbPassword.Visible = true;
               lbEmail.Visible = true;
               dataGridView1.Visible = true;
               btnBack.Visible = true;
               
           }

            if (usernameTb.Text != "" && passwordTb.Text != "" && rbUser.Checked == true)
            {
               
                dataGridView1.Visible = true;
                usernameTb.Visible = false;
                passwordTb.Visible = false;
                rbUser.Visible = false;
                rbArministrator.Visible = false;
                usernameLb.Visible = false;
                passwordLb.Visible = false;
                roleLb.Visible = false;
                btnSingIn.Visible = false;
                btnBack.Visible = true;
                }

            if (usernameTb.Text =="")
            {
                MessageBox.Show("The username cannot be empty");
            }

            else 
                if (passwordTb.Text=="")
                {
                    MessageBox.Show("The password cannot be ampty");
                }
         
                else
                     if (rbArministrator.Checked==true)
                   {
                      rbUser.Checked = false;
                   }
                     else
                         if (rbUser.Checked==true)
                         {
                             rbArministrator.Checked = false;
                         }
                         else 
                             if (rbUser.Checked==false && rbArministrator.Checked == false)
                             {
                                 MessageBox.Show("You  must to choose admin or user!");
                             }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            usernameTb.Visible =true;
            passwordTb.Visible = true;
            rbUser.Visible = true;
            rbArministrator.Visible = true;
            usernameLb.Visible = true;
            passwordLb.Visible = true;
            roleLb.Visible = true;
            btnSingIn.Visible = true;
            tbID.Visible = true;
            tbUsername.Visible = true;
            tbPassword.Visible = true;
            tbEmail.Visible = true;
            btnInsert.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            lbID.Visible = true;
            lbUsername.Visible = true;
            lbPassword.Visible = true;
            lbEmail.Visible = true;
            dataGridView1.Visible = true;
            btnBack.Visible = false;
        }
    }
}
