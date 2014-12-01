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
    public partial class Form3 : Form
    {
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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            reader();
        }
    }
}
