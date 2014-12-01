using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManager.Entities;

namespace UsersManager.Repositories
{
    public class RolesRepository
    {
        private readonly string connectionString;

        public RolesRepository (string connectionString)
        {
            this.connectionString = connectionString;
        }

        private void Insert(Role item)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand command = new OleDbCommand(
                    "INSERT INTO Roles([RoleName]) " +
                    "VALUES (@RoleName)",
                    dbConnection);

                command.Parameters.AddWithValue("@RoleName", item.RoleName);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
            }
        }

        private void Update(Role item)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            using (dbConnection)
            {
                OleDbCommand command = new OleDbCommand(
                    "UPDATE Role SET RoleName = @RoleName " +
                    "WHERE ID = @id",
                    dbConnection);

                command.Parameters.AddWithValue("@RoleName", item.RoleName);
                command.Parameters.AddWithValue("@id", item.ID);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
            }
        }

        public Role GetById(int id)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Roles WHERE ID=@id", dbConnection);
                command.Parameters.AddWithValue("@id", id);

                OleDbDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Role role = new Role();
                        role.ID = (int)reader["ID"];
                        role.RoleName = (string)reader["RoleName"];

                        return role;
                    }
                }
            }

            return null;
        }

        public List<Role> GetAll()
        {
            List<Role> result = new List<Role>();

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Roles", dbConnection);
                OleDbDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Role role = new Role();
                        role.ID = (int)reader["ID"];
                        role.RoleName = (string)reader["RoleName"];

                        result.Add(role);
                    }

                }
            }

            return result;
        }

        public void Delete(Role item)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM Roles WHERE ID=@id", dbConnection);
                command.Parameters.AddWithValue("@id", item.ID);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }

            }
        }

        public void Save(Role item)
        {
            if (item.ID > 0)
            {
                Update(item);
            }
            else
            {
                Insert(item);
            }
        }        
    }
}
