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
    public partial class frmMai : Form
    {
        public static string selectedUser;
        public frmMai()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection();
            conn.ConnectionString = @"Data Source=..\..\users.sdf";
            string sqlQuery = "SELECT * FROM users";
            SqlCeCommand cmd = new SqlCeCommand(sqlQuery, conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                listBox1.Items.Add(rd.GetValue(0).ToString());
                listBox2.Items.Add("Password: " + rd.GetValue(1).ToString() + ", Names: " + rd.GetValue(2).ToString() + ", email: " + rd.GetValue(3).ToString() + ",admin:" + rd.GetValue(4).ToString());
            }

            conn.Close();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                frmEdit edit = new frmEdit();
                edit.ShowDialog();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                SqlCeConnection sqlConnection = new SqlCeConnection();
                SqlCeCommand sqlCommand = new SqlCeCommand();

                sqlConnection.ConnectionString = @"Data Source=..\..\users.sdf";
                sqlCommand = new SqlCeCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "Delete from users where username='" + listBox1.SelectedItem.ToString() + "';";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Success!");

                refresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = listBox1.SelectedItem.ToString();
        }
    }
}
