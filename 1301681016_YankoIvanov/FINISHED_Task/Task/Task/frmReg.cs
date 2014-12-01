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
    public partial class frmReg : Form
    {
        private bool message_show;

        public frmReg()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            message_show = Auth.RegisterNewUser(tbUsername.Text,tbNames.Text,tbPassword.Text);

            if (message_show == true)
            {
                MessageBox.Show("Successfuly registered!");

                this.Close();
            }
            else MessageBox.Show("Username already exists!");
        }
    }
}
