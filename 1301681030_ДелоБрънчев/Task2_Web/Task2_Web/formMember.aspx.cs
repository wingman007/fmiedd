using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task2_Web.Entity;
using Task2_Web.Repository;

namespace Task2_Web
{
    public partial class formMember : System.Web.UI.Page
    {
        private void Load_lsBox()
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();
            ListBox1.Items.Clear();
            foreach (User user in users)
            {
                ListBox1.Items.Add(user.Id.ToString() + ". " + user.FirstName + " " + user.LastName);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count == 0)
            {
                lbSelect.Text = "Select for Update or Delete!";
                Load_lsBox();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();
            foreach (User user in users)
            {
                if (ListBox1.SelectedItem.Text.Substring(0, 3).Contains(user.Id.ToString()))
                {
                    txtId.Text = user.Id.ToString();
                    txtFname.Text = user.FirstName;
                    txtSname.Text = user.LastName;
                    txtPassword.Text = user.Password;
                    txtRole.Text = user.Role;
                }
            }
        }
    }
}