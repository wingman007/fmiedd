using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace danostane
{
    public partial class LoginForm : Form
    {
        static bool login = false; 
        static OleDbDataReader dr = null; 
        static OleDbCommand cmd = new OleDbCommand(); 
        static OleDbConnection cn = new OleDbConnection();
        public static bool user; 
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //"Provider=SQLNCLI11;Data Source=FMI-532-0\\SQLEXPRESS;User ID=sa;Password = sa;Initial Catalog=Users";
            cn.ConnectionString = @"Provider=SQLNCLI11;Data Source=DANY-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Users";
            cmd.Connection = cn; 
        }
        public void Authentication()
        {
            string authentication_username = textBox1.Text; 
            string authentication_password = textBox2.Text;
            string username = ""; 
            string password = "";
            try
            
            {
                string q = "select * from roles";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        username = dr[1].ToString().TrimEnd();
                        password = dr[2].ToString().TrimEnd();
                        if(authentication_username == username && authentication_password == password)
                        {
                            login = true;
                        }
                    }
                    if(login == true)
                    {
                        MessageBox.Show("Logged as " + authentication_username);
                        if(authentication_username == "admin")
                        {
                            user = true;
                        }
                        else 
                        {
                            user = false;
                        }
                        this.Hide();
                        Form1 form1 = new Form1(); 
                        form1.Show(); 
                        dr.Close();
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        authentication_username = "";
                        authentication_password = "";
                        username = "";
                        password = "";
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication();
        }
    }
}
