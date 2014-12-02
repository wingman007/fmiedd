using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.db1DataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ivan" && textBox2.Text == "vacation")
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                dataGridView1.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Input correct login information!");
            }
        }
    }
}
