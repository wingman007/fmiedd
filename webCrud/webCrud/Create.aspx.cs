using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCrud.Models;

namespace webCrud
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getConstring()
        {
            string constr = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            return constr;
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {

           
                string uname = TextBox1.Text;
                string password = TextBox2.Text;
                string email = TextBox3.Text;
                string str = getConstring();
                SqlConnection con = new SqlConnection(str);
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [user]([username], [password],  [email])VALUES ('" + uname + " ',' " + password + "','" + email + " ' )", con);

             
             
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", "alert('Data Inserted Succesfully')", true);

                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";

                    }
               
            
        }

      
    }

}