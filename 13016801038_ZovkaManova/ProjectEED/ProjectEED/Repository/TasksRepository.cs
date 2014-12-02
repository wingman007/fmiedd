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
    public class TasksRepository
    {


        public SqlConnection conn = null;

        public TasksRepository()
        {
            this.conn = new SqlConnection();
            this.conn.ConnectionString = "Data Source=FMI-431-2\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=False; User ID=sa; Password=sa";
        }


        public Tassk GetByID(int id)
        {
            Tassk task = null;


            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[tasks] WHERE [id]=@id";

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
                    task = new Tassk();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Name = reader["name"].ToString();
                    task.Description = reader["description"].ToString();
                }
            }
            finally
            {
                conn.Close();
            }
            return task;
        }
        public List<Tassk> GetAll()
        {

            List<Tassk> result = new List<Tassk>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [tasks]";

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tassk task = new Tassk();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Name = reader["name"].ToString();
                    task.Description = reader["description"].ToString();
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public List<Tassk> GetAll(int userId)
        {

            List<Tassk> result = new List<Tassk>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [tasks] WHERE [parentuserid]="+userId;

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tassk task = new Tassk();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Name = reader["name"].ToString();
                    task.Description = reader["description"].ToString();
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public void EditTask(Tassk item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            if (item.ID > 0)
            {
                cmd.CommandText = @"
UPDATE tasks SET
[parentuserid]=@parentuserid,
[name]=@name,
[description]=@description
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

                param = cmd.CreateParameter();
                param.ParameterName = "@parentuserid";
                param.Value = item.ParentUserID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@description";
                param.Value = item.Description;
                cmd.Parameters.Add(param);


            }
            else
            {
                cmd.CommandText = @"
INSERT INTO tasks
(
[name],
[parentuserid],
[description]
)
VALUES(
@name,
@parentuserid,
@description
)";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@name";
                param.Value = item.Name;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@parentuserid";
                param.Value = item.ParentUserID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@description";
                param.Value = item.Description;
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

        public void Delete(Tassk item)
        {

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
DELETE FROM[tasks]
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