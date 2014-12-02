using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDdbProject
{
    public partial class LoginForm : Form
    {
        public string username, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regform = new RegistrationForm();
            regform.ShowDialog();
            //this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new System.IO.StreamReader("C:\\" + txtloginUsername.Text + "\\login.ID");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                if (username == txtloginUsername.Text && password == txtloginPassword.Text)
                {
                    MessageBox.Show("You logged in!","Success!");
                    CRUDeditorForm editorform = new CRUDeditorForm();
                    editorform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is wrong!", "Error!");
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("The user doesn't exist!", "Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
