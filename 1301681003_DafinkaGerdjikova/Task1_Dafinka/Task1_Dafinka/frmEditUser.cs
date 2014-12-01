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
    public partial class frmEditUser : Form
    {
        User user;
        public frmEditUser(User user)
        {
            InitializeComponent();
            this.user = user;


        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(this.Text = user.ID == 0 ? "New user" : "Edit user");

            RolesRepository rolesRepo = new RolesRepository();
            foreach (Role role in rolesRepo.GetAll())
            {
                cmbRoles.Items.Add(role);
                if (user.RoleID == role.ID)
                    cmbRoles.SelectedItem = role;
            }


            this.tbFname.Text = user.FirstName;
            this.tbLnama.Text = user.LastName;
            this.tbUsername.Text = user.Username;
            this.tbPassword.Text = user.Password;
            this.tbEmail.Text = user.Email;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFname.Text) || string.IsNullOrWhiteSpace(tbLnama.Text) || string.IsNullOrWhiteSpace(tbEmail.Text)
               || string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {

            }
            else if (cmbRoles.SelectedIndex <= 0)
            {
                MessageBox.Show("You have missed to select role!");
                return;
            }
            else
            {
                Role role = (Role)cmbRoles.SelectedItem;

                user.Username = tbUsername.Text;
                user.FirstName = tbFname.Text;
                user.LastName = tbLnama.Text;
                user.Password = tbPassword.Text;
                user.Email = tbEmail.Text;
                user.RoleID = role.ID;

                UsersRepository userRepo = new UsersRepository();
                userRepo.EditUser(user);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
