using ConsolePhonebook.Entity;
using ConsolePhonebook.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.OleDb;


namespace ConsolePhonebook.Repository
{
    public class ContactsRepository
    {
        private OleDbConnection myconn = new OleDbConnection(AuthenticationService.connectionstring);

        public void Insert(Contact item)
        {
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myconn;

            
            
            OleDbParameter myParam1 = new OleDbParameter("@userId",item.ParentUserId);
           
            OleDbParameter myParam2 = new OleDbParameter("@fname", item.FirstName);
            
            OleDbParameter myParam3 = new OleDbParameter("@lname", item.LastName);
           
            OleDbParameter myParam4 = new OleDbParameter("@email",item.Email);
            
            myCommand.CommandText=
            @"INSERT INTO Contacts (userId,fname,lname,email) Values (@userId,@fname,@lname,@email)";

            
            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);
            try
            {
                myconn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }
        }

        public void Update(Contact item)
        {

             OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myconn;

            OleDbParameter myParam0 = new OleDbParameter("@contactID",item.Id);
            

            OleDbParameter myParam1 = new OleDbParameter("@userId", item.ParentUserId);
           

            OleDbParameter myParam2 = new OleDbParameter("@fname", item.FirstName);
           

            OleDbParameter myParam3 = new OleDbParameter("@lname",item.LastName);
           

            OleDbParameter myParam4 = new OleDbParameter("@email",item.Email);
           

            myCommand.CommandText=
    @"UPDATE Contacts SET userId=@userId,fname=@fname,lname=@lname,email=@email WHERE contactID=@contactID";
           
            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);
            myCommand.Parameters.Add(myParam0);
            Console.WriteLine("Contact updated successfully");

            try
            {
                myconn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }

        }



        public Contact GetById(int id)
        {
            Contact contact = new Contact();

            OleDbParameter myParam1 = new OleDbParameter("@contactID", id);

            string oString = @"select * from Contacts where contactID=@contactID";
            OleDbCommand oCmd = new OleDbCommand(oString, myconn);
            oCmd.Parameters.Add(myParam1);
            // or oCmd.Parameters.AddWithValue("@Fname", fName);

            try
            {
                myconn.Open();
                OleDbDataReader oReader = oCmd.ExecuteReader();
                while (oReader.Read())
                {
                    contact.Id = Convert.ToInt32(oReader["contactID"]);
                    contact.ParentUserId = Convert.ToInt32(oReader["userId"]);
                    contact.FirstName = oReader["fname"].ToString();
                    contact.LastName = oReader["lname"].ToString();
                    contact.Email = oReader["email"].ToString();

                }
                oReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }

            return contact;
        }

        public List<Contact> GetAll(int parentUserId)
        {
            List<Contact> result = new List<Contact>();

            OleDbParameter myParam1 = new OleDbParameter("@userId", parentUserId);

            try
            {
                string sql = @"select * from Contacts where userId=@userId";
                OleDbCommand cmd = new OleDbCommand(sql, myconn);
                cmd.Parameters.Add(myParam1);
                myconn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contact contact = new Contact();
                    contact.Id = Convert.ToInt32(dr["contactID"]);
                    contact.ParentUserId = Convert.ToInt32(dr["userId"]);
                    contact.FirstName = dr["fname"].ToString();
                    contact.LastName = dr["lname"].ToString();
                    contact.Email = dr["email"].ToString();

                    if (contact.ParentUserId == parentUserId)
                    {
                        result.Add(contact);
                    }
                    
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }

            return result;
        }

        

        public void Delete(Contact item)
        {
            OleDbParameter myParam0 = new OleDbParameter("@contactID",item.Id);

            OleDbParameter myParam1 = new OleDbParameter("@userId",item.ParentUserId);

            OleDbParameter myParam2 = new OleDbParameter("@fname",  item.FirstName);

            OleDbParameter myParam3 = new OleDbParameter("@lname",item.LastName);

            OleDbParameter myParam4 = new OleDbParameter("@email", item.Email);

            OleDbCommand myCommand = new OleDbCommand(
    @"Delete from Contacts WHERE contactID=@contactID", myconn);
            myCommand.Parameters.Add(myParam0);
            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);


            try
            {
                myconn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }
            Console.WriteLine("A contact was deleted!");
        }

        public void Save(Contact item)
        {
            if (item.Id > 0)
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