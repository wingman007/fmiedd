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

namespace LASTtry
{
    public partial class Form1 : Form
    {
        Manager m = new Manager();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_crt_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserName = txbuser.Text;
            u.Password = txbpass.Text;
            u.Email = txbemail.Text;
            if (txbuser.Text == "" || txbpass.Text==""||txbemail.Text=="")
            {
                MessageBox.Show("Please fill in all the fields");
            }
            else
            {
                m.Insert(u);
                MessageBox.Show("Done!");
            }
           
            
            txbuser.Clear();
            txbpass.Clear();
            txbemail.Clear();

        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            cmb_per.DataSource = m.FillComboBox();
            
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            Users OldUsers = new Users();
            Users NewUsers = new Users();

            OldUsers = cmb_per.SelectedItem as Users;
            NewUsers.UserName = tuser.Text;
            NewUsers.Password = tpass.Text;
            NewUsers.Email = temail.Text;
            if (tuser.Text=="")
            {
                NewUsers.UserName = OldUsers.UserName;
            }
            if (tpass.Text=="")
            {
                NewUsers.Password = OldUsers.Password;
            }
            if (temail.Text=="")
            {
                NewUsers.Email = OldUsers.Email;
            }
            m.Update(OldUsers,NewUsers);

            cmb_per.DataSource = m.FillComboBox();
            MessageBox.Show("Done!");
            tuser.Clear();
            tpass.Clear();
            temail.Clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u = cmb_per.SelectedItem as Users;
            m.Delete(u);

            cmb_per.DataSource = m.FillComboBox();
            MessageBox.Show("Done!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
