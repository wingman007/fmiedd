using ProjectEED.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEED.Repository
{
    class RolesRepository
    {
         public SqlConnection conn = null;

        public RolesRepository()
        {
            this.conn = new SqlConnection();
            this.conn.ConnectionString = "Data Source=FMI-431-2\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=False; User ID=sa; Password=sa";
        }

       
        public Role GetByID(int id)
        {
            Role role = null;


            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[roles] WHERE [id]=@id";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "id";
            param.Value = id;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new Role();
                    role.ID = (int)reader["id"];
                    role.Name = reader["name"].ToString();
                }
            }
            finally
            {
                conn.Close();
            }
            return role;
        }
        public List<Role> GetAll()
        {

            List<Role> result = new List<Role>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [roles]";

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Role role = new Role();

                    role.ID = (int)reader["id"];
                    role.Name = reader["name"].ToString();
                    result.Add(role);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public void EditRole(Role item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            if (item.ID > 0)
            {
                cmd.CommandText = @"
UPDATE roles SET
[name]=@name
WHERE
[id]=@id
";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@name";
                param.Value = item.Name;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = item.ID;
                cmd.Parameters.Add(param);
            }
            else
            {
                cmd.CommandText = @"
INSERT INTO roles
(
[name]
)
VALUES(
@name
)";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@name";
                param.Value = item.Name;
                cmd.Parameters.Add(param);
            }
            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                this.conn.Close();
            }
        }

        public void Delete(Role item)
        {

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
DELETE FROM[roles]
WHERE
id=@id
";
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = item.ID;
            cmd.Parameters.Add(param);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
