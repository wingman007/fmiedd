using CRUD_Project.Controllers;
using CRUD_Project.Models;
using CRUD_Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.Views
{
    public partial class EditUser : MetroFramework.Forms.MetroForm
    {
        private int userId;

        private User user;

        ControllerUser ctrlUser;

        public EditUser(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            ctrlUser = new ControllerUser();
            user = ctrlUser.GetById(userId);
            textBoxUsername.Text = user.Username;
            textBoxPass.Text = user.Password;
            textBoxEmail.Text = user.Email;

            switch (user.RoleID)
            {
                case 1:
                    metroRadioButton1.Checked = true;
                    break;
                case 2:
                    metroRadioButton2.Checked = true;
                    break;
                case 3:
                    metroRadioButton3.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void ClearTextBoxes()
        {
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxEmail.Clear();
        }

        private void metroButtonRegister_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text.Length <= 0 || textBoxPass.Text.Length <= 0 || textBoxEmail.Text.Length <= 0)
            {
                MessageBox.Show("Empty fields are not allowed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBoxes();
                return;
            }
  
            User newUser = new User
            {
                Id = user.Id,
                Username = textBoxUsername.Text,
                Password = textBoxPass.Text,
                Email = textBoxEmail.Text,
                RoleID = user.RoleID
            };

            ctrlUser.Edit(newUser);
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            this.Close();
            LogIn form1 = new LogIn();
            form1.Show();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                user.RoleID = 1;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                user.RoleID = 2;
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {
                user.RoleID = 3;
            }
        }

    }
}
