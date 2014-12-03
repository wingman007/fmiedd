using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD2.Models;

namespace CRUD2
{

    public partial class AdminForm : System.Web.UI.Page
    {
        public static int index;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            DropDownList1.Visible = true;
            Button2.Visible = true;
            Label8.Visible = true;
            TextBox6.Visible = true;
            RequiredFieldValidator5.Visible = true;
            requiredUsername.Visible = true;
            RequiredFieldValidator1.Visible = true;
            RequiredFieldValidator2.Visible = true;
            RequiredFieldValidator3.Visible = true;
            RequiredFieldValidator4.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                Users U = new Users();
                U.ID = Convert.ToInt32(TextBox6.Text);
                U.role_id = Convert.ToInt32(TextBox6.Text);
                U.Username = TextBox1.Text;
                U.Password = TextBox2.Text;
                U.Firstname = TextBox3.Text;
                U.Lastname = TextBox4.Text;
                U.Email = TextBox5.Text;
                U.role = DropDownList1.SelectedItem.Text;

                Repo d = new Repo();

                d.INSERT(U); // Insert user
                Label7.Text = "User created successfully!!!";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            gridUsers.Visible = true;
            try
            {
                Repo r = new Repo();
                gridUsers.DataSource = r.List();
                gridUsers.DataBind();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            Label8.Visible = true;
            TextBox6.Visible = true;
            Button5.Visible = true;
            GridView1.Visible = true;
            try
            {
                Repo r = new Repo();
                GridView1.DataSource = r.List();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text != string.Empty)
            {
                try
                {

                    Users user = new Users();
                    Repo r = new Repo();
                    user.ID = Convert.ToInt32(TextBox6.Text);
                    r.DELETE(user);

                    Label7.Text = "Delete success click VIEW to see the change!";
                    gridUsers.DataBind();




                }
                catch (FormatException)
                {
                    Label7.Text = "Invalid Id!";
                }
            }
            else
            {
                Label7.Text = "Fail!";

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }


    }
}






