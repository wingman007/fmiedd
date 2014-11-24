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
using System.Data.SqlServerCe;
using System.Data.Sql;

namespace Proekt_Osvobojdenie
{
    public partial class frmMain : Form
    {
        private static string ConnectionDBString = @"Data Source=..\..\UsersCE.sdf";
        private string admin = frmLogin.adminlevel;

        SqlCeConnection conn = new SqlCeConnection();
        SqlCeCommand cmd = new SqlCeCommand();

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (frmLogin.adminlevel == "2")
            {
                //admin
                tsMemberRead.Visible = false;
            }
            else if (frmLogin.adminlevel == "1")
            {
                //Member
                toolStripDropDownButton1.Visible = false;
                listboxNames.Visible = false;
                listboxPass.Visible = false;
                listboxEmail.Visible = false;
                listboxAdmin.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                this.Size = new Size(212, 325);
            }
        }

        public void refreshContacts()
        {
            listboxUsers.Items.Clear();
            listboxPass.Items.Clear();
            listboxNames.Items.Clear();
            listboxEmail.Items.Clear();
            listboxAdmin.Items.Clear();
            conn.ConnectionString = ConnectionDBString;
            cmd = new SqlCeCommand("SELECT * FROM UsersCEDB", conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                listboxUsers.Items.Add(rd.GetValue(0).ToString());
                listboxNames.Items.Add(rd.GetValue(1).ToString());
                listboxPass.Items.Add(rd.GetValue(2).ToString());
                listboxEmail.Items.Add(rd.GetValue(3).ToString());
                if (rd.GetValue(4).ToString() == "2")
                {
                    listboxAdmin.Items.Add("Admin");
                }
                else if (rd.GetValue(4).ToString() == "1")
                {
                    listboxAdmin.Items.Add("Member");
                }
                else listboxAdmin.Items.Add("Public");
            }
            conn.Close();
        }

        public frmMain()
        {
            InitializeComponent();

            refreshContacts();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            MessageBox.Show("You have been successfully logged out!");
            frmLogin.Show();

            this.Close();
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            frmUserInfo userinfo = new frmUserInfo();
            userinfo.Show();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            frmReg frmReg = new frmReg();
            frmReg.ShowDialog();
        }

        private void tsbtnRead_Click(object sender, EventArgs e)
        {
            listboxUsers.Items.Clear();
            listboxPass.Items.Clear();
            listboxNames.Items.Clear();
            listboxEmail.Items.Clear();
            listboxAdmin.Items.Clear();
            conn.ConnectionString = ConnectionDBString;
            cmd = new SqlCeCommand("SELECT * FROM UsersCEDB", conn);
            conn.Open();
            SqlCeDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                listboxUsers.Items.Add(rd.GetValue(0).ToString());
                listboxNames.Items.Add(rd.GetValue(1).ToString());
                listboxPass.Items.Add(rd.GetValue(2).ToString());
                listboxEmail.Items.Add(rd.GetValue(3).ToString());
                if (rd.GetValue(4).ToString() == "2")
                {
                    listboxAdmin.Items.Add("Admin");
                }
                else if (rd.GetValue(4).ToString() == "1")
                {
                    listboxAdmin.Items.Add("Member");
                }
                else listboxAdmin.Items.Add("Public");
            }
            conn.Close();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit();
            if (listboxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a record first, if no records click Functions->Read!");
            }
            else frmEdit.ShowDialog();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (listboxUsers.SelectedIndex != -1)
            {
                DialogResult deleteOK = MessageBox.Show("Are you sure you want to delete selected record?", "Warning", MessageBoxButtons.YesNo);
                if (deleteOK == DialogResult.Yes)
                {
                   conn.ConnectionString = ConnectionDBString;
                   cmd = new SqlCeCommand();
                   cmd.CommandType = System.Data.CommandType.Text;
                   cmd.CommandText = "Delete from UsersCEDB where username='" + listboxUsers.SelectedItem.ToString() + "';";
                   cmd.Connection = conn;

                   conn.Open();
                   if (listboxUsers.SelectedIndex != -1)
                   {
                       cmd.ExecuteNonQuery();
                       MessageBox.Show("Record successfuly deleted!");
                   }
                   else MessageBox.Show("Select username to delete!", "Error!");
                   conn.Close();
                }
            }else MessageBox.Show("Please select username!");

            refreshContacts();
        }

        private void listboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxNames.SelectedIndex = listboxUsers.SelectedIndex;
            listboxPass.SelectedIndex = listboxUsers.SelectedIndex;
            listboxEmail.SelectedIndex = listboxUsers.SelectedIndex;
            listboxAdmin.SelectedIndex = listboxUsers.SelectedIndex;

            if (listboxUsers.SelectedIndex!=-1)
            {
                frmEdit.selecteditemUsers = listboxUsers.SelectedItem.ToString();
                frmEdit.selecteditemPass = listboxPass.SelectedItem.ToString();
                frmEdit.selecteditemNames = listboxNames.SelectedItem.ToString();
                frmEdit.selecteditemEmail = listboxEmail.SelectedItem.ToString();
                frmEdit.selectedAdmin = listboxAdmin.SelectedItem.ToString();
            }
        }

        private void tsMemberRead_Click(object sender, EventArgs e)
        {
            refreshContacts();
        }

        private void btnExitSystem_Click(object sender, EventArgs e)
        {

        }
    }
}

