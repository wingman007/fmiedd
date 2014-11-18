using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePhonebookDB.Entity;
using System.Data;
using System.Data.OleDb;

namespace ConsolePhonebookDB.Repository
{
    class ContactsRepository
    {
        private OleDbConnection connection = null;

        public ContactsRepository()
        {
            this.connection = new OleDbConnection();
            this.connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ivailo\Desktop\ConsolePhonebookDB\ConsolePhonebookDB\Data\Data.mdb";
        }

        public List<Contact> GetAll()
        {
            List<Contact> resultSet = new List<Contact>();

            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
SELECT
  id,
  userid,
  phones
FROM
  Contacts
";
            
            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    resultSet.Add(new Contact()
                    {
                        ID = Convert.ToInt32(reader["id"]),
                        UserId = Convert.ToInt32(reader["userid"]),
                        Phone = Convert.ToString(reader["phones"])

                    });
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return resultSet;

        }

        public Contact GetContactById(int id)
        {
            Contact contact = new Contact();
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
SELECT
  *
FROM 
  Contacts
WHERE
  id = @id
";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contact.ID = Convert.ToInt32(reader["id"]);
                    contact.UserId = Convert.ToInt32(reader["userid"]);
                    contact.Phone = Convert.ToString(reader["phones"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return contact;
        }

        public List<Contact> GetContacts(int LoggedUserID)
        {
            List<Contact> resultSet = new List<Contact>();

            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
SELECT
  id,
  userid,
  phones
FROM
  Contacts
WHERE
  Contacts.userid = @LoggedUserID
";
            cmd.Parameters.AddWithValue("@LoggedUserID", LoggedUserID);

            try
            {
                this.connection.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    resultSet.Add(new Contact()
                    {
                        ID = Convert.ToInt32(reader["id"]),
                        UserId = Convert.ToInt32(reader["userid"]),
                        Phone = Convert.ToString(reader["phones"])
                        
                    });
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return resultSet;
        }

        public void AddPhone(Contact contact)
        {
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
INSERT INTO Contacts(
  userid,
  phones
)
VALUES(
  @userid,
  @phones
)
";
            cmd.Parameters.AddWithValue("@userid", contact.UserId);
            cmd.Parameters.AddWithValue("@phones", contact.Phone);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public void EditPhone(Contact contact)
        {
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
UPDATE Contacts
  SET phones = @phones
WHERE
  id = @id
";
            cmd.Parameters.AddWithValue("@id", contact.ID);
            cmd.Parameters.AddWithValue("@phones", contact.Phone);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public void DeletePhone(Contact contact)
        {
            OleDbCommand cmd = this.connection.CreateCommand();
            cmd.Connection = this.connection;
            cmd.CommandText = @"
DELETE FROM 
  Contacts
WHERE
  id = @id
";
            cmd.Parameters.AddWithValue("@id", contact.ID);

            try
            {
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
