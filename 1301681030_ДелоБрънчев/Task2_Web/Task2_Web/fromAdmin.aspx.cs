using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task2_Web.Entity;
using Task2_Web.Repository;

namespace Task2_Web
{
    public partial class fromAdmin : System.Web.UI.Page
    {
        public static int index;
        private void Clear()
        {
            txtId.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtSname.Text = string.Empty;
            txtPassword.Text = string.Empty;
            ddl_role.SelectedIndex = 0;
        }
        private string messLink(string text, bool pro)
        {
            if (pro == true) messBox.ForeColor = Color.Green;
            else messBox.ForeColor = Color.Red;
            return messBox.Text = text;

        }
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
                    index = user.Id;
                    txtId.Text = user.Id.ToString();
                    txtFname.Text = user.FirstName;
                    txtSname.Text = user.LastName;
                    txtPassword.Text = user.Password;
                    if (user.Role.Contains("public"))
                        ddl_role.SelectedIndex = 1;
                    else
                        if (user.Role.Contains("member"))
                            ddl_role.SelectedIndex = 2;
                        else
                            ddl_role.SelectedIndex = 3;
                }
            }
            messBox.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtFname.Text != string.Empty && txtSname.Text != string.Empty && ddl_role.SelectedIndex != 0)
            {
                User user = new User();
                UserRepository userRepository = new UserRepository();

                try
                {
                    user.Id = Convert.ToInt32(txtId.Text);
                    user.FirstName = txtFname.Text;
                    user.LastName = txtSname.Text;
                    user.Password = txtPassword.Text;
                    user.Role_id = Convert.ToInt32(txtId.Text);
                    user.Role = ddl_role.SelectedItem.ToString();
                    userRepository.Insert(user);
                    Clear();
                    messLink("Create success!", true);
                    Load_lsBox();
                }
                catch (FormatException)
                {
                    messLink("Can't invalid Id!", false);
                }
                catch (InvalidOperationException)
                {
                    messLink("Can't duplicate Id!", false);
                }
            }
            else
            {
                messLink("Fail!", false);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtFname.Text != string.Empty && txtSname.Text != string.Empty && ddl_role.SelectedIndex != 0)
            {                
                try
                {
                    if (index == Convert.ToInt32(txtId.Text))
                    {
                        User user = new User();
                        UserRepository userRepository = new UserRepository();
                        user.Id = Convert.ToInt32(txtId.Text);
                        userRepository.Delete(user);
                        Clear();
                        messLink("Delete success!", true);
                        Load_lsBox();
                    }
                    else messLink("Selected Id is differently from textbox Id!!", false);
                }
                catch (FormatException)
                {
                    messLink("Invalid Id!", false);
                }
            }
            else
            {
                messLink("Fail!", false);
                Clear();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtFname.Text != string.Empty && txtSname.Text != string.Empty && ddl_role.SelectedIndex != 0)
            {
                try
                {
                    if (index == Convert.ToInt32(txtId.Text))
                    {
                        User user = new User();
                        UserRepository userRepository = new UserRepository();
                        user.Id = index;
                        user.FirstName = txtFname.Text;
                        user.LastName = txtSname.Text;
                        user.Password = txtPassword.Text;
                        user.Role_id = index;
                        user.Role = ddl_role.SelectedItem.ToString();
                        userRepository.Update(user);
                        Clear();
                        messLink("Update success!", true);
                        Load_lsBox();
                    }
                    else messLink("Can't update Id!", false);
                }
                catch (FormatException)
                {
                    messLink("Invalid Id!", false);
                }
            }
            else
            {
                messLink("Update Fail!", false);
            }
        }
    }
}