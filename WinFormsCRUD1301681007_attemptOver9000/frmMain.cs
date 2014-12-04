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

namespace WinFormsCRUD1301681007_attemptOver9000
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            AuthenticationService.IsAdmin();

            if (AuthenticationService.isAdmin == false)
            {
                btnMainAdministration.Visible = false;
            }
        }

        private void mnuAdministration_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMainAdministration_Click(object sender, EventArgs e)
        {
            frmAdministration frmAdmin = new frmAdministration();
            frmAdmin.MdiParent = this;
            frmAdmin.Show();
        }

        private void btnMainView_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple CRUD windows forms application made by Petyo Ruzhin.");
        }
    }
}
