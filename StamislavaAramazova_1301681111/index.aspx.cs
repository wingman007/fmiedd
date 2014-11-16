using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace StamislavaAramazova1301681111
{
    public partial class index : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void bttnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
            "Data Source=Aramazovi;" +
            "Initial Catalog=User;" +
            "Integrated Security=True;";
            connection.Open();

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Users(id,username,password,email) VALUES(@id,@username,@password,@email)";

                command.Parameters.AddWithValue("@id", txt_id.Text);
                command.Parameters.AddWithValue("@username", txt_user.Text);
                command.Parameters.AddWithValue("@password", txt_pass.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);

                command.ExecuteNonQuery();
                GridView1.DataBind();
                connection.Close();
            }
        }
    }
}