using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Source;

namespace Task
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            if (Auth.LoggedUserCheckPermission() == false)
            {
                tsAdministration.Visible = false;
            }
        }

        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsMenuLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("You have been successfully logged out!");
            frmLogin.Show();

            this.Close();
        }

        private void tsAdminstrAdministration_Click(object sender, EventArgs e)
        {
            frmAdministration frmAdmin = new frmAdministration();
            frmAdmin.ShowDialog();
        }

        private void tsMenuUser_Click(object sender, EventArgs e)
        {
            frmUserInfo frminfo = new frmUserInfo();
            frminfo.ShowDialog();
        }
    }
}
