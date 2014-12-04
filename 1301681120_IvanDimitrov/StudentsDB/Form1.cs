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
using System.Configuration;
using System.Security;
using System.Security.Principal;


namespace StudentsDB
{
    public partial class formLoading : Form
    {
        SqlConnection dataConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentsDB.Properties.Settings.STUDENTS"].ConnectionString);
        DBSheet dbForm = new DBSheet();
        ControlForms.UserPanel uPanel = new ControlForms.UserPanel();
        Register regForm = new Register();

        public formLoading()
        {
            InitializeComponent();
            #region Username & Password TextBox Hint

            tbUserLogin.ForeColor = Color.Gray; 
            tbUserLogin.Text = "Type your username here ... ";
            this.tbUserLogin.Leave += new System.EventHandler(this.tbUserLogin_Leave);
            this.tbUserLogin.Enter += new System.EventHandler(this.tbUserLogin_Enter);

            tbPwdLogin.ForeColor = Color.Gray;
            tbPwdLogin.Text = "Type your password here ... ";
            this.tbPwdLogin.Leave += new System.EventHandler(this.tbPwdLogin_Leave);
            this.tbPwdLogin.Enter += new System.EventHandler(this.tbPwdLogin_Enter);
            #endregion

        }


        #region Username and Password text changes
        private void tbUserLogin_Enter(object sender, EventArgs e)
        {
            if (tbUserLogin.Text == "Type your username here ... ")
            {
                tbUserLogin.Text = "";
                tbUserLogin.ForeColor = Color.Black;
            }
        }
        private void tbUserLogin_Leave(object sender, EventArgs e)
        {
            if (tbUserLogin.Text.Length == 0)
            {
                tbUserLogin.Text = "Type your username here ... ";
                tbUserLogin.ForeColor = Color.Gray;
            }
        }

        private void tbPwdLogin_Enter(object sender, EventArgs e)
        {
            if (tbPwdLogin.Text == "Type your password here ... ")
            {
                tbPwdLogin.Text = "";
                tbPwdLogin.PasswordChar = '*';
                tbPwdLogin.ForeColor = Color.Black;
            }
        }
        private void tbPwdLogin_Leave(object sender, EventArgs e)
        {
            if (tbPwdLogin.Text.Length == 0)
            {
                tbPwdLogin.Text = "Type your password here ... ";
                tbPwdLogin.ForeColor = Color.Gray;
            }
        }
        #endregion


        private void formLoading_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(tbUserLogin.Text == string.Empty))
                {
                    if (!(tbPwdLogin.Text == string.Empty))
                    {
                        dataConnect.Open();
                        String query = "SELECT * FROM Users WHERE username = @username and password = @password";
                        SqlCommand cmd = new SqlCommand(query, dataConnect);
                        cmd.Parameters.AddWithValue("@username", tbUserLogin.Text);
                        cmd.Parameters.AddWithValue("@password", tbPwdLogin.Text);
                        SqlDataReader dbr;
                        int isLogged = 0;
                        dbr = cmd.ExecuteReader();
                        while (dbr.Read())
                        {
                            isLogged = isLogged + 1;
                        }
                        if (isLogged == 1)
                        {
                            dbr.Close();
                            string roleChecker = string.Empty;
                            String roleQuery = "SELECT * FROM Users WHERE username = @username";
                            SqlCommand roleCmd = new SqlCommand(roleQuery, dataConnect);
                            roleCmd.Parameters.AddWithValue("@username", tbUserLogin.Text);
                            SqlDataReader roleRead;
                            roleRead = roleCmd.ExecuteReader();
                            roleRead.Read();
                            roleChecker = roleRead.GetValue(4).ToString();
                            if (roleChecker == "3")
                            {
                                dbForm.Show();
                            }
                            else if (roleChecker != "3")
                            {
                                uPanel.Show();
                            }
                        }
                        else if (isLogged > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            finally
            {
                dataConnect.Close();
                
            }
        }

        private void formLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            regForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
