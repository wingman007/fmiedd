using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace CRUDdbProject
{
    public partial class CRUDeditorForm : Form
    {
        public SqlCeConnection cn = new SqlCeConnection(@"Data Source = C:\Users\fmi\Source\Repos\fmiedd\1301681106_IvanMadinFTW\CRUDdbProject\CRUDdbProject\database.sdf");

        public CRUDeditorForm()
        {
            InitializeComponent();
        }

        private void CRUDeditorForm_Load(object sender, EventArgs e)
        {
            btnDelete.Hide();
            btnDelete.Enabled = false;
            btnUpdate.Hide();
            btnUpdate.Enabled = false;
        }

        private void CRUDeditorForm_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string SqlCeQuery = "SELECT * FROM tblUsers";
                SqlCeCommand cm = new SqlCeCommand(SqlCeQuery, cn);
                SqlCeDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    lbuserName.Items.Add(dr.GetValue(0).ToString());
                    lbPass.Items.Add(dr.GetValue(2).ToString());
                    lbEmail.Items.Add(dr.GetValue(3).ToString());
                    lbId.Items.Add(dr.GetValue(4).ToString());
                    lbAge.Items.Add(dr.GetValue(1).ToString());
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //check the age are they int

            // I just tried something new because my database doesnt wanted to load... thats why i have Age too...
            int age;
            bool isInteger = int.TryParse(txtAge.Text, out age);

            if (isInteger)
            {
                SqlCeCommand cm = new SqlCeCommand("INSERT INTO tblUsers(userName, age, passWord, eMail) VALUES(@userName, @age, @passWord, @eMail)", cn);
                cm.Parameters.AddWithValue("@userName", txtUserName.Text);
                cm.Parameters.AddWithValue("@age", txtAge.Text);
                cm.Parameters.AddWithValue("@passWord", txtPass.Text);
                cm.Parameters.AddWithValue("@eMail", txtEmail.Text);

                try
                {
                    int affectedRows = cm.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Insert success! \nPress Refresh button to view the changes!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserName.Clear();
                        txtAge.Clear();
                        txtPass.Clear();
                        txtEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insert not success!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No data inserted! Age is not valid!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SqlCeCommand cm = new SqlCeCommand("UPDATE FROM tblUsers WHERE username='" + lbuserName.SelectedItem.ToString() + "'", cn);
            //SqlCeCommand cm = new SqlCeCommand("UPDATE INFO SET userName='"+txtUserName.Text+"',age='"+txtAge.Text.ToString()+"' , passWord= '"+txtPass.Text+"', eMail='"+txtEmail.Text+"' WHERE userName='"+lbuserName.SelectedItem.ToString()+"', passWord= '"+lbPass.SelectedItem.ToString()+"', eMail= '"+lbEmail.SelectedItem.ToString()+"'",cn);
            //2 SqlCeCommand cm = new SqlCeCommand("UPDATE tblUsers SET userName='" + txtUserName.Text + "',age='" + txtAge.Text.ToString() + "' , passWord= '" + txtPass.Text + "', eMail='" + txtEmail.Text + "' WHERE userName='" + lbuserName.SelectedItem.ToString() + "', passWord= '" + lbPass.SelectedItem.ToString() + "', eMail= '" + lbEmail.SelectedItem.ToString() + "'", cn);
            //cm.CommandType = System.Data.CommandType.Text;
            //The update button is crashing and i dont know why!!!

            if (lbuserName.SelectedIndex != -1)
            {

                if (txtUserName.Text != "" & txtPass.Text != "" & txtEmail.Text != "" & txtAge.Text != "")
                {
                    SqlCeCommand cm = new SqlCeCommand("UPDATE tblUsers SET userName= @userName,age= @age , passWord= @passWord , eMail= @eMail WHERE iD= @iD", cn);
                    //cm.Parameters.AddWithValue("@txtUserName", txtUserName.Text);
                    //cm.Parameters.AddWithValue("@age",txtAge.Text);
                    //cm.Parameters.AddWithValue("@passWord",txtPass.Text);
                    //cm.Parameters.AddWithValue("@eMail", txtEmail.Text);
                    //cm.Parameters.AddWithValue("@iD", lbId.SelectedItem.ToString());
                    cm.Parameters.AddRange(new[] {
                    new SqlCeParameter("@userName", txtUserName.Text),
                    new SqlCeParameter("@age",txtAge.Text),
                    new SqlCeParameter("@passWord",txtPass.Text),
                    new SqlCeParameter("@eMail", txtEmail.Text),
                    new SqlCeParameter("@iD", lbId.SelectedItem)

                });
                    //MessageBox.Show("THE UPDATE BUTTON IS CRASHING!!! I DONT KNOW WHY... at cm.ExecuteNonQuery();");
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record Updated! \nPress Refresh button to view the changes!");
                    txtUserName.Clear();
                    txtPass.Clear();
                    txtEmail.Clear();
                    txtAge.Clear();
                }
                else
                {
                    MessageBox.Show("You must fill all textboxes before pressing Update! \nPress Ok for auto filling the textboxes!");
                    txtUserName.Text = lbuserName.SelectedItem.ToString();
                    txtPass.Text = lbPass.SelectedItem.ToString();
                    txtEmail.Text = lbEmail.SelectedItem.ToString();
                    txtAge.Text = lbAge.SelectedItem.ToString();
                }
            }
            else
            {
                MessageBox.Show("You must select Username first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCeCommand cm = new SqlCeCommand("DELETE FROM tblUsers WHERE username='" + lbuserName.SelectedItem.ToString() + "'", cn);
            cm.CommandType = System.Data.CommandType.Text;

            if (lbuserName.SelectedIndex != -1)
            {

                cm.ExecuteNonQuery();
                MessageBox.Show("Record Deleted! \nPress Refresh button to view the changes!");

            }
            else
            {
                MessageBox.Show("You must select Username first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string SqlCeQuery = "SELECT * FROM tblUsers";
            SqlCeCommand cm = new SqlCeCommand(SqlCeQuery, cn);
            SqlCeDataReader dr = cm.ExecuteReader();
            lbId.Items.Clear();
            lbuserName.Items.Clear();
            lbPass.Items.Clear();
            lbEmail.Items.Clear();
            lbAge.Items.Clear();
            while (dr.Read())
            {
                lbuserName.Items.Add(dr.GetValue(0).ToString());
                lbPass.Items.Add(dr.GetValue(2).ToString());
                lbEmail.Items.Add(dr.GetValue(3).ToString());
                lbId.Items.Add(dr.GetValue(4).ToString());
                lbAge.Items.Add(dr.GetValue(1).ToString());
            }
        }

        private void lbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedIndex != -1)
            {
                lbId.SelectedIndex = lb.SelectedIndex;
                lbuserName.SelectedIndex = lb.SelectedIndex;
                lbPass.SelectedIndex = lb.SelectedIndex;
                lbEmail.SelectedIndex = lb.SelectedIndex;
                lbAge.SelectedIndex = lb.SelectedIndex;
                btnDelete.Show();
                btnDelete.Enabled = true;
                btnUpdate.Show();
                btnUpdate.Enabled = true;
            }
        }
    }
}
