using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Николай_Вълков_1301681029_втора_задача
{
    public partial class Form1 : Form
    {

        private void crudFunc(string zaqvka)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=НИКСАН-PC\SQLEXPRESS;Initial Catalog=users-:);Integrated Security=True");
            try
            {
                sqlc.Open();
                statusStrip1.Text = "Connection state succesfully";
                SqlCommand cmd = sqlc.CreateCommand();
                cmd.CommandText = zaqvka;
                try
                {
                    cmd.ExecuteNonQuery();
                    statusStrip1.Text = "Record inserted successfully!";
                    sqlc.Close();
                }
                catch (Exception le)
                {
                    MessageBox.Show(le.Message);
                    statusStrip1.Text = "Record fail!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void reader()
        {
            //"Provider=SQLNCLI11;Data Source=FMI-532-0\\SQLEXPRESS;User ID=sa;Password = sa;Initial Catalog=Users";
            SqlConnection sqlc = new SqlConnection(@"Data Source=НИКСАН-PC\SQLEXPRESS;Initial Catalog=users-:);Integrated Security=True");
            try
            {
                sqlc.Open();
                statusStrip1.Text = "Connection state succesfully";
                SqlCommand cmd = sqlc.CreateCommand();
                cmd.CommandText = @"SELECT NAME, PASSWORD, role from Table_1 join Roles on ID = role_id";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) == txtUname.Text && reader.GetString(1) == txtPass.Text)
                    {
                        string role = reader.GetString(2);
                        if (txtUname.Text != "" && txtPass.Text != "")
                        {
                            if (role == "admin" || role == "Admin")
                            {
                                form_2.ShowDialog();
                                toolStripStatusLabel1.Text = "Correct!";
                            }
                            else
                            {
                                if (role == "member" || role == "Member")
                                {
                                    form_3.ShowDialog();
                                }
                                else
                                {
                                    toolStripStatusLabel1.Text = "Invalid username or password!";
                                }
                            }
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Please insert username and password";
                        }
                    }
                }
                reader.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    statusStrip1.Text = "Readed successfully!";
                    sqlc.Close();
                }
                catch (Exception le)
                {
                    MessageBox.Show(le.Message);
                    statusStrip1.Text = "Can't read!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Form2 form_2 = new Form2();
        Form3 form_3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            reader();
        }
    }
}
