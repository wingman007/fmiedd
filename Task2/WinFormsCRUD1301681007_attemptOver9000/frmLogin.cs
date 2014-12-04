using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCRUD1301681007_attemptOver9000.Service;
using WinFormsCRUD1301681007_attemptOver9000.dsUsersTableAdapters;

namespace WinFormsCRUD1301681007_attemptOver9000
{
    public partial class frmLogin : Form
    {
        public static string loggedUser;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticationService.GetByUsernameAndPassword(tbUsername.Text, tbPassword.Text);

            if (AuthenticationService.isLogged == true)
            {
                loggedUser = tbUsername.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                this.tbPassword.Text = "";
                this.tbUsername.Text = "";
                return;
            }
            
        }

        //private void btnRegister_Click(object sender, EventArgs e)
        //{
            
        //    frmUser frmRegisterUser = new frmUser();
        //    frmRegisterUser.Text = "Register";

        //    DialogResult registerResult = frmRegisterUser.ShowDialog();
            
        //    if (registerResult == DialogResult.OK)
        //    {
        //        MessageBox.Show("User successfully registered!");
        //    }
        //}
    }
}
