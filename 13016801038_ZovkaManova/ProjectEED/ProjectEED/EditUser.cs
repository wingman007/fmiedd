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
    public partial class EditUser : Form
    {

        public User user;
        public void SetUser(User user)
        {
            this.user = user;
        }
        public User Get()
        {
            return this.user;
        }

        public EditUser()
        {

            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
             UsersRepository repo = new UsersRepository();
             Role role = (Role)comboBox1.SelectedItem;
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
            
       
            ManageUsers mngUsers = new ManageUsers();
            this.Hide();
            mngUsers.Show();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            RolesRepository rolesRepo = new RolesRepository();
            Role role = rolesRepo.GetByID(user.RoleID);
            if(user!=null)
            {
                txtUsername.Text = user.Username.TrimEnd();
                txtPassword.Text = user.Password.TrimEnd();
                txtFirstname.Text = user.Firstname.TrimEnd();
                txtLastname.Text = user.Lastname.TrimEnd();
                txtEmail.Text = user.Email.TrimEnd();
                comboBox1.SelectedItem = role;
                comboBox1.SelectedText = role.Name;
                
                foreach(Role r in rolesRepo.GetAll())
                {
                    comboBox1.Items.Add(r);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageUsers mngUsers = new ManageUsers();
            mngUsers.Show();
        }
    }
}
