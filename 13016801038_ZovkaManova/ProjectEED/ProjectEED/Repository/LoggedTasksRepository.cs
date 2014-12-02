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
    class LoggedTasksRepository
    {
         public SqlConnection conn = null;

        public LoggedTasksRepository()
        {
            this.conn = new SqlConnection();
            this.conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True";
        }


        public LoggedTask GetByID(int id)
        {
            LoggedTask task = null;


            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT*FROM[loggedtasks] WHERE [id]=@id";

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
                    task = new LoggedTask();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Task = reader["task"].ToString();
                    task.LoggedTime = double.Parse(reader["description"].ToString());
                    task.Finsihed = bool.Parse(reader["finished"].ToString());
                }
            }
            finally
            {
                conn.Close();
            }
            return task;
        }
        public List<LoggedTask> GetAll()
        {

            List<LoggedTask> result = new List<LoggedTask>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [loggedtasks]";

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LoggedTask task = new LoggedTask();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Task = reader["task"].ToString();
                    task.LoggedTime = double.Parse(reader["loggedtime"].ToString());
                    task.Finsihed = bool.Parse(reader["finished"].ToString());
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public List<LoggedTask> GetAll(int userId)
        {

            List<LoggedTask> result = new List<LoggedTask>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [loggedtasks] WHERE [parentuserid]="+userId;

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LoggedTask task = new LoggedTask();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Task = reader["task"].ToString();
                    task.LoggedTime = double.Parse(reader["loggedtime"].ToString());
                    task.Finsihed = bool.Parse(reader["finished"].ToString());
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public List<LoggedTask> GetAll(string taskName)
        {

            List<LoggedTask> result = new List<LoggedTask>();

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM [loggedtasks] WHERE [task]=" + taskName;

            try
            {
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LoggedTask task = new LoggedTask();
                    task.ID = (int)reader["id"];
                    task.ParentUserID = (int)reader["parentuserid"];
                    task.Task = reader["task"].ToString();
                    task.LoggedTime = double.Parse(reader["loggedtime"].ToString());
                    task.Finsihed = bool.Parse(reader["finished"].ToString());
                    result.Add(task);
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public void EditTask(LoggedTask item)
        {
            IDbCommand cmd = this.conn.CreateCommand();
            if (item.ID > 0)
            {
                cmd.CommandText = @"
UPDATE loggedtasks SET
[parentuserid]=@parentuserid,
[task]=@task,
[loggedtime]=@loggedtime,
[finished]=@finished
WHERE
[id]=@id
";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@parentuserid";
                param.Value = item.ParentUserID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = item.ID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@task";
                param.Value = item.Task;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@loggedtime";
                param.Value = item.LoggedTime;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@finished";
                param.Value = item.Finsihed;
                cmd.Parameters.Add(param);


            }
            else
            {
                cmd.CommandText = @"
INSERT INTO loggedtasks
(
[task],
[parentuserid],
[loggedtime],
[finished]
)
VALUES(
@task,
@parentuserid,
@loggedtime,
@finished
)";
                IDataParameter param = cmd.CreateParameter();
                param.ParameterName = "@task";
                param.Value = item.Task;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@parentuserid";
                param.Value = item.ParentUserID;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@loggedtime";
                param.Value = item.LoggedTime;
                cmd.Parameters.Add(param);

                param = cmd.CreateParameter();
                param.ParameterName = "@finished";
                param.Value = item.Finsihed;
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

        public void Delete(LoggedTask item)
        {

            IDbCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
DELETE FROM[loggedtasks]
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
