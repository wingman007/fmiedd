using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IvanAramazov1301681083
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\C# DATABASE\IvanAramazov1301681083\IvanAramazov1301681083\DB\Users1.accdb;
                Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                CheckConnection.Text = " Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }



        private void bttnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where username = '" + txt_user.Text + "' and password = '" + txt_pass.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (txt_user.Text == "admin" && txt_pass.Text == "admin")
            {
                MessageBox.Show("You have successfuly logged as admin!");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (count == 1)
            {
                MessageBox.Show("You have successfuly logged as member!");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error 404: User not found!");
            }
            connection.Close();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
