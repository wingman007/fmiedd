using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ProjectWinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationService.AuthenticateUser(tbUsername.Text, tbPassword.Text);
            if (AuthenticationService.LoggedUser != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

