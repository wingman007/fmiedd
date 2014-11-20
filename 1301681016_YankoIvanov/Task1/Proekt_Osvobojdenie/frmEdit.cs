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

namespace Proekt_Osvobojdenie
{
    public partial class frmEdit : Form
    {
        private static string ConnectionDBString = @"Data Source=..\..\UsersCE.sdf";
        public static string register = null;
        public static string selecteditemUsers = null;
        public static string selecteditemNames = null;
        public static string selecteditemPass = null;
        public static string selecteditemEmail = null;
        public static string selectedAdmin = null;

        public frmEdit()
        {
            InitializeComponent();

            cbRights.SelectedIndex = 0;

            if (selecteditemUsers != null && selecteditemNames != null && selecteditemPass != null && selecteditemEmail != null && selectedAdmin != null)
            {
                tbUsr.Text = selecteditemUsers;
                tbNames.Text = selecteditemNames;
                tbPass.Text = selecteditemPass;
                tbEmail.Text = selecteditemEmail;
                tbAdmin.Text = selectedAdmin;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                SqlCeConnection sqlConnection = new SqlCeConnection();
                sqlConnection.ConnectionString = ConnectionDBString;

                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                string admincheck;
                if (cbRights.SelectedIndex == 0)
                {
                    admincheck = "2";
                }
                else if (cbRights.SelectedIndex == 1)
                {
                    admincheck = "1";
                }
                else admincheck = "0";
                cmd.CommandText = "Update UsersCEDB set username='" + tbUsr.Text + "', names ='" + tbNames.Text + "', password='" + tbPass.Text + "', email='" + tbEmail.Text + "', admin='" + admincheck + "' where username='" + selecteditemUsers + "';";
                cmd.Connection = sqlConnection;

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Record successfuly changed, click Functions -> Read to refresh!");
                
                this.Close();
        }
    }
}
