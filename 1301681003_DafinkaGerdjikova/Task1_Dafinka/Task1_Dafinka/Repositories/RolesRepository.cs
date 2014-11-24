using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_Dafinka.Entities;

namespace Task1_Dafinka.Repositories
{
    class RolesRepository
    {
        public IDbConnection conn = null;

        public RolesRepository()
        {
            this.conn = new OleDbConnection();
            this.conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=task1.mdb;";
        }


        public Role GetByID(int id)
        {
            Role role = null;


            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[Roles] WHERE ID=@id";

            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = id;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new Role();
                    role.ID = (int)reader["ID"];
                    role.Name = (string)reader["RoleName"];
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

                    role.ID = (int)reader["ID"];
                    role.Name = (string)reader["RoleName"];
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
UPDATE Roles SET
[RoleName]=@RoleName
WHERE
[ID]=@ID
";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@RoleName";
                param.Value = item.Name;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@ID";
                param.Value = item.ID;
                cmd.Parameters.Add(param);
            }
            else
            {
                cmd.CommandText = @"
INSERT INTO Roles
(
[RoleName]
)
VALUES(
@RoleName
)";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@RoleName";
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
DELETE FROM[Roles]
WHERE
ID=@ID
";
            IDataParameter param = cmd.CreateParameter();
            param.ParameterName = "@ID";
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
