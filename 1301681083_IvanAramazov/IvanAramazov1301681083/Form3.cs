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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\C# DATABASE\IvanAramazov1301681083\IvanAramazov1301681083\DB\Users1.accdb;
                Persist Security Info=False;";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users1DataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.users1DataSet2.Users);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "users_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "users_table";
        }

        private void memberLogOt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

    }
}
