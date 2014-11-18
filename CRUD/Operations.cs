using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Operations
    {
        private static string connstring="Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\UserDataBase.mdf;Integrated Security=True";
        private SqlConnection connection=new SqlConnection(connstring);
        private SqlCommand command;
        private SqlDataAdapter adapter=new SqlDataAdapter();
        private DataSet data = new DataSet();
        private DataRow rowdata;
        private DataColumn column;
        private DataTable table;
        private int id;
        private string name;
        private string pass;
        private string email;


        public void Add(string Name, string Email, string Password)
        {
            this.name = Name;
            this.email = Email;
            this.pass = Password;

            command = new SqlCommand("INSERT INTO [User](Username, Password,Email) VALUES (@name,@pass,@meil)", connection);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@meil", email);
            command.Parameters.AddWithValue("@pass", pass); 

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Delete(int id)
        {
            this.id = id;
            command = new SqlCommand("DELETE FROM [User] WHERE Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
        public void Update(int id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.pass = password;

            command = new SqlCommand("UPDATE [User] SET Username=@name, Password=@pass,Email=@meil WHERE ID=@id", connection);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@meil", email);
            command.Parameters.AddWithValue("@pass", pass); 
            command.Parameters.AddWithValue("@id",id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void getByID(int id)
        {
            this.id = id;
            table= data.Tables[0];
            table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
            rowdata = data.Tables[0].Rows.Find(id);
            Console.WriteLine("Username: "+rowdata[1].ToString()+ " Password: "+rowdata[2].ToString()+" Email:"+rowdata[3].ToString());


        }
        public void Read()
        {
            if(getData())
            {
                for(int i=0;i<data.Tables[0].Rows.Count;i++)
                {
                    Console.WriteLine(data.Tables[0].Rows[i]["ID"].ToString() + " " + data.Tables[0].Rows[i]["Username"].ToString()+" "+
                        data.Tables[0].Rows[i]["Email"].ToString() + " " + data.Tables[0].Rows[i]["Password"].ToString());
                }
            }  
        }
        private bool getData()
        {
            try
            {
                command = new SqlCommand("SELECT * FROM [User]", connection);
                data = new DataSet();
                adapter.InsertCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return true;
            }
           catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
