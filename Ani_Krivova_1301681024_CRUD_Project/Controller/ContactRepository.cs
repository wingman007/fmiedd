using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using Ani_Krivova_1301681024_CRUD_Project;
using Ani_Krivova_1301681024_CRUD_Project.Models;

namespace Ani_Krivova_1301681024_CRUD_Project.Controller
{
    public class ContactRepository
    {

        OleDbConnection connection = new OleDbConnection(SomeDataInfo.connectionString);

        private void Create(Ani_Krivova_1301681024_CRUD_Project.Models.Contact contact)
        {
            try 
	        {
                connection.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO Contacts (ID, ParentUserId,FirstName,LastName,Email) Values (@contactID, @ParentUserId,@FirstName,@LastName,@Email)", connection);
                command.Parameters.AddWithValue("@contactID", contact.ContactId);
                command.Parameters.AddWithValue("@ParentUserId", contact.ParentUserId);
                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@Email", contact.Email);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
             
        }

        private Contact Read(int id)
        {
            Models.Contact tempcontact = new Models.Contact();
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT from Users WHERE ID="+id, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tempcontact.ParentUserId =Convert.ToInt32(reader["ParentUserId"]);
                    tempcontact.FirstName = reader["FirstName"].ToString();
                    tempcontact.LastName = reader["LastName"].ToString();
                    tempcontact.Email = reader["Email"].ToString();
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return tempcontact;
        }

        private List<Contact> ReadAll()
        {
            List<Contact> tempcontactlist = new List<Contact>();

            Models.Contact tempcontact = new Models.Contact();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from Users", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tempcontact.ContactId = Convert.ToInt32(reader["ID"]);
                    tempcontact.ParentUserId = Convert.ToInt32(reader["ParentUserId"]);
                    tempcontact.FirstName = reader["FirstName"].ToString();
                    tempcontact.LastName = reader["LastName"].ToString();
                    tempcontact.Email = reader["Email"].ToString();
                    tempcontactlist.Add(tempcontact);
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return tempcontactlist;
        }

        private void Update(Models.Contact contact)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("UPDATE Contact SET ParentUserId=@ParentUserId, FirstName=@fname,LastName=@lname,Email=@Email WHERE ID=@contectid", connection);
                command.Parameters.AddWithValue("@ParentUserId", contact.ParentUserId);
                command.Parameters.AddWithValue("@fname", contact.FirstName);
                command.Parameters.AddWithValue("@lname", contact.LastName);
                command.Parameters.AddWithValue("@Email", contact.Email);
                

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Delete(Models.Contact contact)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("Delete from Users WHERE ID=@contactid", connection);
                command.Parameters.AddWithValue("@ParentUserId", contact.ParentUserId);
                command.Parameters.AddWithValue("@fname", contact.FirstName);
                command.Parameters.AddWithValue("@lname", contact.LastName);
                command.Parameters.AddWithValue("@Email", contact.Email);


                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Save(Models.Contact item)
        {
            if (item.ContactId > 0)
            {
                Update(item);
            }
            else
            {
                Create(item);
            }
        }
    }
}