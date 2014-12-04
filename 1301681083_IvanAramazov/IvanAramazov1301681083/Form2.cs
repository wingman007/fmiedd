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
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\C# DATABASE\IvanAramazov1301681083\IvanAramazov1301681083\DB\Users1.accdb;
                Persist Security Info=False;";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users1DataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users1DataSet1.Users);

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand(@"INSERT INTO Users(ID,username,[password]) VALUES(@ID,@username,@password)", connection);
                cmd.Parameters.AddWithValue("@ID", id_txt.Text);
                cmd.Parameters.AddWithValue("@username", user_txt.Text);
                cmd.Parameters.AddWithValue("@password", pass_txt.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex); 
            }
        }

        private void bttn_edit_Click(object sender, EventArgs e)
        {
            try
            {              
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = " UPDATE Users Set [username] = @username, [password] = @password Where [ID]=@ID";
                cmd.Parameters.AddWithValue("@username", "" + user_txt.Text + "");
                cmd.Parameters.AddWithValue("@password", "" + pass_txt.Text + "");
                cmd.Parameters.AddWithValue("@ID", "" + id_txt.Text + "");
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Edited");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                string query = "DELETE FROM Users WHERE ID='"+ id_txt.Text+"'";
                cmd.CommandText = query;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "users_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "users_table";

            id_txt.Text = "";
            pass_txt.Text = "";
            user_txt.Text = "";


        }

        private void adminLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }


    }
}
