using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CRUDProject
{
    public partial class index : System.Web.UI.Page
    {

        OleDbConnection aConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Nikolay\\Desktop\\Users1.accdb");

        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox1.Visible = true;
            aConnection.Open();
            OleDbCommand comm = new OleDbCommand("SELECT * from users", aConnection);
            OleDbDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string result = "ID: ";
                result += reader.GetValue(0);

                result += " Name: ";
                result += reader.GetString(1);

                result += " Email: ";
                result += reader.GetString(3);
                ListBox1.Items.Add(result);

            }
            reader.Close();
            aConnection.Close();
        }

        private void Clear()
        {
            id.Text = "";
            username.Text = "";
            password.Text = "";
            email.Text = "";
        }

        protected void buttonadd_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && username.Text != "" && password.Text != "" && email.Text != "") 
            {
                aConnection.Open();
                OleDbCommand comm = new OleDbCommand("INSERT INTO [Users]([ID],[username],[password],[email]) VALUES(@id, @username, @password, @email)", aConnection);
     
                comm.Parameters.AddWithValue("@id", id.Text);
                comm.Parameters.AddWithValue("@username", username.Text);
                comm.Parameters.AddWithValue("@password", password.Text);
                comm.Parameters.AddWithValue("@email", email.Text);
                comm.ExecuteNonQuery();
                aConnection.Close();
                Clear();
                ListBox1.Items.Clear();
                Page_Load(sender , e);  
            }
        }

       

        protected void buttonedit_Click(object sender, EventArgs e)
        {


            if (id.Text != "" && username.Text != "" && password.Text != "" && email.Text != "")
            {
                aConnection.Open();
                OleDbCommand comm = new OleDbCommand("UPDATE [Users] SET [username] = @username, [password] = @password, [email] = @email WHERE [ID] = @id", aConnection);
                comm.Parameters.AddWithValue("@id", id.Text);
                comm.Parameters.AddWithValue("@username", username.Text);
                comm.Parameters.AddWithValue("@password", password.Text);
                comm.Parameters.AddWithValue("@email", email.Text);
               
                comm.ExecuteNonQuery();
                aConnection.Close();
                Clear();
                ListBox1.Items.Clear();
                Page_Load(sender, e);               
             

            }
          
        
        }

        protected void buttondelete_Click(object sender, EventArgs e)
        {
            id.Visible = true;
            Label1.Visible = true;
            if (id.Text != "")
            {
                aConnection.Open();
                OleDbCommand comm = new OleDbCommand("delete from users where id='" + id.Text + "'", aConnection);
                try
                {
                    comm.ExecuteNonQuery();
                    aConnection.Close();
                    Clear();
                    ListBox1.Items.Clear();
                    Page_Load(sender, e);  
                }
                finally { }
            }
            else
            {

            }
        }

    }
}