using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1_Dafinka.Entities;

namespace Task1_Dafinka
{
    public partial class frmEditRole : Form
    {
        Role role;
        public frmEditRole(Role role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("You have missed to write something!");
                return;
            }
            else
            {
                role.Name = tbName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(this.Text = role.ID == 0 ? "New role" : "Edit role");
            tbName.Text = role.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
