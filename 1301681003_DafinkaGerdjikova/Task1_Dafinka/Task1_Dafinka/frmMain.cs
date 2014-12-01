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
using Task1_Dafinka.Repositories;
using Task1_Dafinka.Service;

namespace Task1_Dafinka
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RolesRepository rolesRepo = new RolesRepository();
            User user = AuthenticationService.LoggedUser;
            Role role = rolesRepo.GetByID(user.RoleID);
            if (role != null)
            {
                if (role.Name == "Administrator")
                {
                    tsRoles.Visible = true;
                }
                else
                {
                    tsRoles.Visible = false;
                }
            }
        }

        private void tsRoles_Click(object sender, EventArgs e)
        {
            frmRoles frm = new frmRoles();
            frm.Show();
        }


    }
}
