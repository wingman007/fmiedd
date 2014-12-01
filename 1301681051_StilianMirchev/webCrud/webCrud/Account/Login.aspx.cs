using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCrud.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private bool AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string CS = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
           
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                
              
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@UserName", username);
                SqlParameter paramPassword = new SqlParameter("@Password", password);

                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(txtUserName.Text, txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, CheckBox1.Checked);
            }
            else
            {
                lblMessage.Text = "Invalid User Name and/or Password";
            } 
       
            
            
            string CS1 = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            SqlConnection con1 = new SqlConnection(CS1);
            SqlCommand comn = new SqlCommand("Select * from Log_form where log_uname=@UserName and log_pass=@Password",con1);
            comn.Parameters.AddWithValue("@UserName", txtUserName.Text);
            comn.Parameters.AddWithValue("@Password", txtPassword.Text);
            con1.Open();
            var rd = comn.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Session["Username"] = rd["log_uname"].ToString();
                    int roles = Convert.ToInt32(rd["user_role"].ToString());
                    switch (roles) { 
                        case 0:
                            Response.Redirect("~/SimpleView.aspx");
                            break;
                        case 1:
                            Response.Redirect("~/View.aspx");
                            break;
                    
                    }
                }

            }


           
        
        }
    
    
    }
}