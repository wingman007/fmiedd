using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Roles
    {
        private static DataConnection dataconnection = new DataConnection();
        private static string connstring = dataconnection.ConnString();
        private SqlConnection connection = new SqlConnection(connstring);
        private SqlCommand command;
        private SqlDataReader reader;
        private string username;
        private string pass;
        public int role_id{get;private set;}

        public Roles (string username, string pass)
        {
            this.username = username;
            this.pass = pass;
        }

        public void CheckLogInInfo()
        {
            command = new SqlCommand("Select u.Role_Id from [User] u left join [Roles] r on u.Role_Id=r.ID where username=@username and password=@pass",connection);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@pass", pass);

            connection.Open();
            reader=command.ExecuteReader();
            while(reader.Read())
            {
                role_id = reader.GetInt32(0);
            }
        }

    }
}
