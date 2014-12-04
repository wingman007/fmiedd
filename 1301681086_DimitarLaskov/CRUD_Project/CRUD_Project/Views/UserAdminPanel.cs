using CRUD_Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.Views
{
    public partial class UserAdminPanel : MetroFramework.Forms.MetroForm
    {
        public UserAdminPanel()
        {
            InitializeComponent();
        }

        private void UserAdminPanel_Load(object sender, EventArgs e)
        {
            ControllerUser ctrUser = new ControllerUser();

            var users = ctrUser.GetAll();

            int count = 0;
            foreach (var item in users)
            {
                listView1.Items.Add(item.Id.ToString());
                listView1.Items[count].SubItems.Add(item.Username);
                listView1.Items[count].SubItems.Add(item.Password);
                listView1.Items[count].SubItems.Add(item.Email);
                listView1.Items[count].SubItems.Add(item.Role.RoleName);
                count++;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerUser ctrlUser = new ControllerUser();
                ctrlUser.Delete(Convert.ToInt32(listView1.SelectedItems[0].Text));
                UserAdminPanel_Activated(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("No items are selected!");
            }
        }

        private void UserAdminPanel_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            UserAdminPanel_Load(sender, e);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(listView1.SelectedItems[0].Text);

            if (currentId != ControllerUser.currentUser.Id)
            {
                EditUser editUser = new EditUser(currentId);
                editUser.ShowDialog();
            }
        }
    }
}
