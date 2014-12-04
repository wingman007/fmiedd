using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDdbProject
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm loginform = new LoginForm();
            //loginform.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try 
            { 
                var sw= new System.IO.StreamWriter("C:\\" + txtregUsername.Text+ "\\login.ID");
                sw.Write(txtregUsername.Text + "\n" + txtregPassword.Text);
                //sw.WriteLine(txtregUsername.Text);
                //sw.Write(txtregPassword.Text);
                sw.Close();
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory("C:\\" + txtregUsername.Text);
                var sw = new System.IO.StreamWriter("C:\\" + txtregUsername.Text + "\\login.ID");
                sw.Write(txtregUsername.Text + "\n" + txtregPassword.Text);
                sw.Close();
            }
            this.Close();
        }
    }
}
