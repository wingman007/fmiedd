using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radion1301681076
{
    public partial class frmLogin : Form
    {
        private string message;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message=connect.connnectMe(textBox1.Text, textBox2.Text);
            MessageBox.Show(message);
            if (message == "success")
            {
                this.Hide();
                frmMai main = new frmMai();
                main.Show();
            }
            else MessageBox.Show("incorrect username or password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        } 
    }
}
