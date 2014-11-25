using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1301681035
{
    public partial class Form1 : Form
    {
        public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\App_Data\\Database11.accdb;Persist Security Info=True");

        OleDbCommand myCommand = new OleDbCommand("SELECT * from users", myConnection);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.database11DataSet1.users);
            // TODO: This line of code loads data into the 'database11DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database11DataSet.users);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            myConnection.Open();

            int numb = IDDropList.SelectedIndex;
            OleDbCommand myCommand = new OleDbCommand("UPDATE users SET username = '" + username_box.Text + "', `password` = '" + password_box.Text + "', email = '" + email_box.Text + "' WHERE ID = " + numb + ";", myConnection);

            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            myCommand.CommandText = "INSERT INTO users (username,`password`,email) VALUES ('" + username_box.Text + "','" + password_box.Text + "','" + email_box.Text + "')";

            myCommand.ExecuteNonQuery();
            myConnection.Close();
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            int numb = IDDropList2.SelectedIndex;
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM users WHERE ID = " + numb + ";", myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();

            
        }

    }
}
