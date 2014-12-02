using ProjectEED.Entity;
using ProjectEED.Repository;
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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManageUsers mngUsers = new ManageUsers();
            UsersRepository repo = new UsersRepository();
            Role role = (Role)comboBox1.SelectedItem;

            User user = new User();

            if (txtUsername.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.Username = txtUsername.Text.TrimEnd();
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.Password = txtPassword.Text.TrimEnd();
            }
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.Firstname = txtFirstname.Text.TrimEnd();
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.Email = txtEmail.Text.TrimEnd();
            }
            if (txtLastname.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.Lastname = txtLastname.Text.TrimEnd();
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("The textbox can't be empty!");
                return;
            }
            else
            {
                user.RoleID = role.ID;
            }

            repo.EditUser(user);

            this.Hide();
           
            mngUsers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageUsers mngUsers = new ManageUsers();
            mngUsers.Show();
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            RolesRepository rolesRepo = new RolesRepository();
            comboBox1.Items.Clear();
            foreach(Role role in rolesRepo.GetAll())
            {
                comboBox1.Items.Add(role);
            }
        }
    }
}
