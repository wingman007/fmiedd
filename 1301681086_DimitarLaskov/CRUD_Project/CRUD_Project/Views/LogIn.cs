using CRUD_Project.Controllers;
using CRUD_Project.Models;
using CRUD_Project.View;
using CRUD_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.View
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ControllerUser ctr1 = new ControllerUser();
            User user = ctr1.LoginAuthentication(textBoxUsername.Text, textBoxPassword.Text);

            if (user != null)
            {
                this.Hide();
                Main form2 = new Main();
                ControllerUser.currentUser = user;
                form2.mainForm = this;
                form2.Show();
            }
            else
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.PreviousForm = this;
            this.Hide();
            register.Show();
        }

    }
}
