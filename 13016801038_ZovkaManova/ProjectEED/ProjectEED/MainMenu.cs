using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEED
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageTasks form = new ManageTasks();
            form.Show();
            this.Close();
        }
    }
}
