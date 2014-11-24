using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace AccessWinFormApplication___CRUD
{
    public partial class Form1 : Form
    {
        Manager m = new Manager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserName = tbUN.Text;
            u.Password = tbPass.Text;
            u.Email = tbE.Text;
            if (tbUN.Text == "" || tbPass.Text == "" || tbE.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
            }
            else
            {
                m.Insert(u);
                MessageBox.Show("Done!");
            }

            //cmbCreated.
            tbUN.Clear();
            tbPass.Clear();
            tbE.Clear();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            cmbCreated.DataSource = m.FillComboBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Users OldUsers = new Users();
            Users NewUsers = new Users();

            OldUsers = cmbCreated.SelectedItem as Users;
            NewUsers.UserName = tbUserName.Text;
            NewUsers.Password = tbPassword.Text;
            NewUsers.Email = tbEmail.Text;
            if (tbUserName.Text == "")
            {
                NewUsers.UserName = OldUsers.UserName;
            }
            if (tbPassword.Text == "")
            {
                NewUsers.Password = OldUsers.Password;
            }
            if (tbEmail.Text == "")
            {
                NewUsers.Email = OldUsers.Email;
            }
            m.Update(OldUsers, NewUsers);

            cmbCreated.DataSource = m.FillComboBox();
            MessageBox.Show("Done!");
            tbUserName.Clear();
            tbPassword.Clear();
            tbEmail.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u = cmbCreated.SelectedItem as Users;
            m.Delete(u);

            cmbCreated.DataSource = m.FillComboBox();
            MessageBox.Show("Done!");
        }
    }
}
