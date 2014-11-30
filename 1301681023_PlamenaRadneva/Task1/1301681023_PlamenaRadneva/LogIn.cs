using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManager.Controllers;

namespace BookManager
{
    public partial class LogIn : Form
    {
        private User LoggedUser = new User();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoggedUser = UserController.LogIn(tb_username.Text, tb_password.Text);

            if (LoggedUser.username == null)
            {
                MessageBox.Show("Invalid username or password!", "Information");
                tb_username.Clear();
                tb_password.Clear();
                tb_username.Focus();

            }
            else 
            {
                BookManager form = new BookManager(LoggedUser);
                form.Show();
                this.Hide();
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
