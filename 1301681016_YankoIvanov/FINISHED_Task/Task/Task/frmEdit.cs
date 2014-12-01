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
    public partial class frmEdit : Form
    {
        SqlCeConnection sqlConnection = new SqlCeConnection();
        SqlCeCommand sqlCommand = new SqlCeCommand();

        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            selectedUserCheck();

            comboboxAdmin.SelectedIndex = 0;
        }

        private void selectedUserCheck()
        {
            sqlConnection.ConnectionString = Auth.ConnectionDBString;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Users where username='" + frmAdministration.selectedUsernameforEdit + "'";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlCeDataReader rd = sqlCommand.ExecuteReader();
            while (rd.Read())
            {
                tbUsername.Text = rd.GetValue(0).ToString();
                tbNames.Text = rd.GetValue(1).ToString();
                tbPassword.Text = rd.GetValue(2).ToString();
                tbAdmin.Text = rd.GetValue(3).ToString();
            }
            sqlConnection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (User_Control.editUser(frmAdministration.selectedUsernameforEdit, tbUsername.Text, tbNames.Text, tbPassword.Text, comboboxAdmin.SelectedItem.ToString()) == true)
            {
                MessageBox.Show("User successfuly changed, please click refresh!");
                this.Close();
            }
            else MessageBox.Show("Username already exists!");
        }
    }
}
