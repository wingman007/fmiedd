using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ProjectWinForm.Repo
{
    class UsersRepository
    {
        public SqlConnection cn = null;
        public UsersRepository()
        {
            this.cn = new SqlConnection();
            this.cn.ConnectionString = @"Data Source=FMI-431-2\SQLEXPRESS;Initial Catalog=yourDatabaseName;User ID=sa;Password=sa";
        }


        public User GetByUserNameandPassword(string username, string password)
        {
            User user = null;


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from users where username=@username AND password=@password";

            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@username";
            param.Value = username;
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.ParameterName = "@password";
            param.Value = password;
            cmd.Parameters.Add(param);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    user = new User();
                    user.id = (int)dr["id"];
                    user.username = (string)dr["username"];
                    user.password = (string)dr["password"];
                    user.email = (string)dr["email"];

                }
            }
            finally
            {
                cn.Close();
            }
            return user;
        }

    }
}

