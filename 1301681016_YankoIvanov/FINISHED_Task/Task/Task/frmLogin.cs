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
    public partial class frmLogin : Form
    {
        private bool message_show;
        public static string loggedUser;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReg frmReg = new frmReg();
            frmReg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            message_show = Auth.ConnectUser(tbUsername.Text,tbPassword.Text);

            if (message_show==true)
            {
                loggedUser = tbUsername.Text;
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else MessageBox.Show("Username or password incorrect!");
        }
    }
}
