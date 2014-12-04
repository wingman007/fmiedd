using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace radion1301681076
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();

            LoadNames();
        }
        private void LoadNames()
        {
            SqlCeConnection conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=..\..\users.sdf";
            string sqlQuery = "SELECT * FROM users where username='"+frmMai.selectedUser+"'";
            SqlCeCommand cmd = new SqlCeCommand(sqlQuery, conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                textBox2.Text = rd.GetValue(0).ToString();
                textBox1.Text = rd.GetValue(1).ToString();
                textBox3.Text = rd.GetValue(2).ToString();
                textBox4.Text = rd.GetValue(3).ToString();
                textBox5.Text = rd.GetValue(4).ToString();
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            SqlCeCommand sqlCommand = new SqlCeCommand();

            sqlConnection.ConnectionString = @"Data Source=..\..\users.sdf";
            sqlCommand = new SqlCeCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "Update users set username='" + textBox2.Text + "', password ='" + textBox1.Text + "', names='" + textBox3.Text + "', email='" + textBox4.Text + "', admin='" + textBox5.Text + "' where username='" + frmMai.selectedUser + "';";
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Success!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Username exists!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
