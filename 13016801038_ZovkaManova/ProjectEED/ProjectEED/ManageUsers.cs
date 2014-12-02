using ProjectEED.Entity;
using ProjectEED.Repository;
using ProjectEED.Service;
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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewUser newForm = new NewUser();
            newForm.Show();
            this.Hide();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshUsers();
            if(AuthenticationService.LoggedUser.RoleID!=1)
            {
                toolStripButton1.Visible = false;
                toolStripButton2.Visible = false;
                btnEdit.Visible = false;
                
            }
        }
        private void RefreshTasks()
        {
            listBox1.Items.Clear();
            User user = (User)lbUsers.SelectedItem;
            TasksRepository tasksRepo = new TasksRepository();
            foreach(Tassk task in tasksRepo.GetAll(user.ID))
            {
                listBox1.Items.Add(task);
            }
        }
        private void RefreshUsers()
        {
            lbUsers.Items.Clear();
            UsersRepository usersRepo = new UsersRepository();

            foreach (User user in usersRepo.GetAll())
            {
                lbUsers.Items.Add(user);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User user = (User)lbUsers.SelectedItem;
            if (lbUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user!");
            }
            else
            {
                EditUser editUser = new EditUser();
                editUser.SetUser(user);
                editUser.Show();
                this.Hide();

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            User user = (User)lbUsers.SelectedItem;

            UsersRepository usersRepo = new UsersRepository();

            if (user == null)
            {
                MessageBox.Show("Please select a user!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    usersRepo.Delete(user);
                    this.Hide();
                    ManageUsers mngUsers = new ManageUsers();
                    mngUsers.Show();
                }
            }

        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTasks();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }
    }
}
