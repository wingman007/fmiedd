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
        private static DataConnection dataconnection=new DataConnection();
        private static string connstring = dataconnection.ConnString();
        private SqlConnection connection=new SqlConnection(connstring);
        private SqlCommand command;
        private SqlDataAdapter adapter=new SqlDataAdapter();
        private SqlCommandBuilder objCommandBuilder;
        private DataSet data = new DataSet("Users");
        private DataRow rowdata;
        private DataTable table;
        private DataColumn idUser;
        private int id;
        private string name;
        private string pass;
        private string email;
        private int role_id;


        public void Add(string Name, string Email, string Password,int role)
        {
            this.name = Name;
            this.email = Email;
            this.pass = Password;
            this.role_id = role;

            

            DataRow row = table.NewRow();
            row["Username"] = name;
            row["Password"] = pass;
            row["Email"] = email;
            row["Role_Id"] = role_id;
            table.Rows.Add(row);
            UpdateDataBase();
        }
        public void Delete(int id)
        {
            this.id = id;
            rowdata = data.Tables[0].Rows.Find(id);
            rowdata.Delete();
            data.AcceptChanges();
        }
        public void Update(int id, string name, string email, string password, int role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.pass = password;
            this.role_id = role;

            rowdata = data.Tables["User"].Rows.Find(id);
            rowdata["Username"] = this.name;
            rowdata["Password"] = this.pass;
            rowdata["Email"] = this.email;
            rowdata["Role_Id"] = this.role_id;
            
            data.AcceptChanges();
          //  UpdateDataBase();
        }
        public void getByID(int id)
        {
            this.id = id;
            rowdata = data.Tables[0].Rows.Find(id);
            Console.WriteLine("Username: "+rowdata["Username"].ToString()+ " Password: "+rowdata["Password"].ToString()+" Email:"+rowdata["Email"].ToString()+" Role:"+rowdata["Role"]);
        }
        public void Read()
        {
            if(getData())
            {
                for (int i = 0; i < data.Tables["User"].Rows.Count; i++)
                {
                    Console.WriteLine(data.Tables[0].Rows[i]["ID"].ToString() + " " + data.Tables[0].Rows[i]["Username"].ToString()+" "+
                        data.Tables[0].Rows[i]["Email"].ToString() + " "+data.Tables[0].Rows[i]["Role"]);
                }
            }  
        }
        private bool getData()
        {
            try
            {
                if(data.Tables.Count.Equals(0))
                {
                    command = new SqlCommand("SELECT u.Id,u.Username,u.Email,u.Password,u.Role_Id,r.ID,r.Role FROM [User] u left join [Roles] r on u.Role_Id=r.ID", connection);
                    data = new DataSet();
                    adapter.InsertCommand = command;
                    adapter.SelectCommand = command;
                    adapter.Fill(data,"User");
                    table = data.Tables["User"];
                    idUser = new DataColumn();
                    idUser = table.Columns["ID"];
                    idUser.DataType = System.Type.GetType("System.Int32");
                    idUser.AutoIncrement = true;
                    long value =(long.Parse(table.Rows[table.Rows.Count-1]["ID"].ToString())) +1;
                    idUser.AutoIncrementSeed = value ;
                    idUser.AutoIncrementStep = 1;
                    table.PrimaryKey = new DataColumn[] { idUser };
                    return true;
                }
               else
               {
                    return true;
               }
            }
           catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public void UpdateDataBase()
        {
            objCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.DeleteCommand = new SqlCommand("");
            adapter.UpdateCommand = objCommandBuilder.GetUpdateCommand(true);
            adapter.InsertCommand = objCommandBuilder.GetInsertCommand(true);
            adapter.Update(data, "User");
        }
    }
}
