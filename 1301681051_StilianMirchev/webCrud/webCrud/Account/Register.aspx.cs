using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace webCrud.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Read the connection string from web.config.
                // ConfigurationManager class is in System.Configuration namespace
                string CS = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
                // SqlConnection is in System.Data.SqlClient namespace
                using (SqlConnection con = new SqlConnection(CS))
                {
                    int role;
                    if (CheckBox1.Checked==true)
                    {
                        role = 1;
                    }
                    else 
                    {
                        role = 0;
                    }
                    SqlCommand cmd = new SqlCommand("spRegisterUser1", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = new SqlParameter("@UserName", txtUserName.Text);
                    // FormsAuthentication calss is in System.Web.Security namespace
                   
                       
                    SqlParameter password = new SqlParameter("@Password", txtPassword.Text);
                    SqlParameter urole = new SqlParameter("@UserRole", role);
                    
                   

                    cmd.Parameters.Add(username);
                    cmd.Parameters.Add(password);
                    cmd.Parameters.Add(urole);
                   

                    con.Open();
                    int ReturnCode = (int)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    {
                        lblMessage.Text = "User Name already in use, please choose another user name";
                    }
                    else
                    {
                        Response.Redirect("~/Account/Login.aspx");
                    }
                }
            }
        }

    
    }
}