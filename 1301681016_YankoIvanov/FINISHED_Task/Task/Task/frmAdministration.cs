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
using Task.Source;

namespace Task
{
    public partial class frmAdministration : Form
    {
        public static string selectedUsernameforEdit;
        SqlCeConnection sqlConnection = new SqlCeConnection();
        SqlCeCommand sqlCommand = new SqlCeCommand();

        public frmAdministration()
        {
            InitializeComponent();

            RefreshUsers();
        }

        private void RefreshUsers()
        {
            listboxUsers.Items.Clear();
            listboxInfo.Items.Clear();
            sqlConnection.ConnectionString = Auth.ConnectionDBString;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM Users";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlCeDataReader rd = sqlCommand.ExecuteReader();

            while (rd.Read())
            {
                listboxUsers.Items.Add(rd.GetValue(0).ToString());
                listboxInfo.Items.Add("Names: " + rd.GetValue(1).ToString() + " ,Password: " + rd.GetValue(2).ToString() + " ,Permission: " + rd.GetValue(3).ToString());
            }
            sqlConnection.Close();
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            frmReg frmReg = new frmReg();
            frmReg.ShowDialog();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (listboxUsers.SelectedIndex != -1)
            {
                DialogResult deleteOK = MessageBox.Show("Are you sure you want to delete selected record?", "Warning", MessageBoxButtons.YesNo);
                if (deleteOK == DialogResult.Yes)
                {
                    if (User_Control.DeleteUser(listboxUsers.SelectedItem.ToString())==true)
                    {
                        MessageBox.Show("User successfuly deleted!");
                    }
                }
            }
            else MessageBox.Show("Please select username!");

            RefreshUsers();
        }

        private void tsEditUser_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit();
            if (listboxUsers.SelectedIndex != -1)
            {
                selectedUsernameforEdit = listboxUsers.SelectedItem.ToString();
                frmEdit.ShowDialog();
            }
            else MessageBox.Show("Select user to edit!");
        }
    }
}
