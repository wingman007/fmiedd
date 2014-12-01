using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Николай_Вълков_1301681029_втора_задача
{
    public partial class Form2 : Form
    {

        private void crudFunc(string zaqvka)
        {
            SqlConnection sqlc = new SqlConnection("Data Source=FMI-532-0\\SQLEXPRESS;User ID=sa;Password = sa;Initial Catalog=users-:)");
            try
            {
                sqlc.Open();
                statusLbl.Text = "Connection state succesfully";
                SqlCommand cmd = sqlc.CreateCommand();
                cmd.CommandText = zaqvka;
                try
                {
                    cmd.ExecuteNonQuery();
                    statusLbl.Text = "Record inserted successfully!";
                    sqlc.Close();
                }
                catch (Exception le)
                {
                    MessageBox.Show(le.Message);
                    statusLbl.Text = "Record fail!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void reader()
        {
            listBox1.Items.Clear();
            //Data Source=НИКСАН-PC\SQLEXPRESS;Initial Catalog=c-sharp-project;Integrated Security=True"
            //Data Source=НИКСАН-PC\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False
            SqlConnection sqlc = new SqlConnection("Data Source=FMI-532-0\\SQLEXPRESS;User ID=sa;Password = sa;Initial Catalog=users-:)");
            try
            {
                sqlc.Open();
                statusLbl.Text = "Connection state succesfully";
                SqlCommand cmd = sqlc.CreateCommand();
                cmd.CommandText = @"SELECT ID, NAME, ADDRESS, PASSWORD, role from Table_1 join Roles on ID = role_id";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    listBox1.Items.Add(id.ToString() + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4));
                }
                reader.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    statusLbl.Text = "Readed successfully!";
                    sqlc.Close();
                }
                catch (Exception le)
                {
                    MessageBox.Show(le.Message);
                    statusLbl.Text = "Can't read!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null && txtUserName.Text == null && txtPass.Text == null && txtEmail.Text == null)
            {
                statusLbl.Text = "Не сте попълнили някое поле!";
            }
            else
            {
                int isInteger;
                if (int.TryParse(txtId.Text, out isInteger))
                {
                    if (txtUserName.Text.Length < 50 && txtPass.Text.Length < 50 && txtEmail.Text.Length < 50)
                    {
                        crudFunc("Insert into Table_1( [ID],[NAME],[ADDRESS],[PASSWORD] ) values('" + Convert.ToInt32(txtId.Text) + "','" + txtUserName.Text + "','" + txtEmail.Text + "','" + txtPass.Text + "')");
                        statusLbl.Text = "Записът е успешен!";
                        if (comboBox1.Text != "")
                        {
                            crudFunc("Insert into Roles( [role_id], role ) values('" + Convert.ToInt32(txtId.Text) + "','" + comboBox1.SelectedItem + "')");
                            statusLbl.Text = "Записът е успешен!";
                        }
                        reader();
                    }
                    else
                    {
                        statusLbl.Text = "Error";
                    }
                }
                else
                {
                    statusLbl.Text = "ID-то полето не е число!";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selecteditem = listBox1.SelectedItem.ToString();
                string selectedItemId = selecteditem.Substring(0, selecteditem.IndexOf(" "));
                if (selectedItemId != "")
                {
                    crudFunc(@"Delete from Table_1 WHERE (ID='" + selectedItemId + "')");
                    statusLbl.Text = "Записът е изтрит успешно!";
                    reader();
                }
                else
                {
                    statusLbl.Text = "Не сте избрали запис!";
                }
            }
            else
            {
                statusLbl.Text = "Не сте избрали запис!";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == null && txtPass.Text == null && txtEmail.Text == null)
            {
                statusLbl.Text = "Не сте попълнили някое поле!";
            }
            else
            {
                string selecteditem = listBox1.SelectedItem.ToString();
                string selectedItemId = selecteditem.Substring(0, selecteditem.IndexOf(" "));
                if (listBox1.SelectedItem != null)
                {
                    if (txtUserName.Text.Length < 50 && txtPass.Text.Length < 50 && txtEmail.Text.Length < 50)
                    {
                        crudFunc(@"Update Table_1 
                        SET NAME ='" + txtUserName.Text + "',ADDRESS='" + txtEmail.Text + "', PASSWORD='" + txtPass.Text + "'WHERE (ID='" + selectedItemId + "')");
                        statusLbl.Text = "Ъпдейта е успешен!";
                        if (comboBox1.Text != "")
                        {
                            crudFunc(@"Update Roles 
                            SET role ='" + comboBox1.SelectedItem + "'WHERE (role_id='" + selectedItemId + "')");
                            statusLbl.Text = "Ъпдейта е успешен!";
                        }
                        reader();
                    }
                    else
                    {
                        statusLbl.Text = "Error";
                    }
                }
                else
                {
                    statusLbl.Text = "Не сте избрали запис за update!";
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            reader();
        }
    }
}
