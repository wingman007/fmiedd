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

namespace Task1_Dafinka
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        public void RefreshRoles()
        {
            lbRoles.Items.Clear();

            RolesRepository rolesRepo = new RolesRepository();
            foreach (Role role in rolesRepo.GetAll())
            {
                lbRoles.Items.Add(role);
            }
            if (lbRoles.Items.Count > 0)
            {
                lbRoles.SelectedIndex = 0;
            }

            AdjustControlls();

        }

        public void AdjustControlls()
        {
            this.btnNew.Enabled = true;
            this.btnEdit.Enabled = this.lbRoles.SelectedItem != null;
            this.btnDelete.Enabled = this.lbRoles.SelectedItem != null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RolesRepository rolesRepo = new RolesRepository();
            Role role = new Role();

            frmEditRole frm = new frmEditRole(role);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                rolesRepo.EditRole(role);
                RefreshRoles();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbRoles.SelectedIndex >= 0)
            {
                RolesRepository rolesRepo = new RolesRepository();

                Role role = (Role)lbRoles.SelectedItem;

                frmEditRole frm = new frmEditRole(role);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    rolesRepo.EditRole(role);
                    RefreshRoles();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbRoles.SelectedIndex >= 0)
            {
                RolesRepository rolesRepo = new RolesRepository();

                Role role = (Role)lbRoles.SelectedItem;
                if (MessageBox.Show("Delete user?", "Delete user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    rolesRepo.Delete(role);
                    RefreshRoles();
                }
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            RefreshRoles();
        }
    }
}
