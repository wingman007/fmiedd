using System;
using System.IO;
using System.Collections.Generic;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Service;
using System.Data;
using System.Data.OleDb;

namespace ConsolePhonebook.Repository
{
    public class UsersRepository
    {
        private OleDbConnection myconn = new OleDbConnection(AuthenticationService.connectionstring);

        private void Insert(User item) 
        {

            OleDbParameter myParam1 = new OleDbParameter("@userId", item.Id);

            OleDbParameter myParam2 = new OleDbParameter("@fname",item.FirstName);

            OleDbParameter myParam3 = new OleDbParameter("@lname", item.LastName);

            OleDbParameter myParam4 = new OleDbParameter("@username", item.Username);

            OleDbParameter myParam5 = new OleDbParameter("@pass",item.Password);

            OleDbCommand myCommand = new OleDbCommand(
                @"INSERT INTO Users (userId, fname,lname,username,pass) Values (@userId, @fname,@lname,@username,@pass)", myconn);

            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);
            myCommand.Parameters.Add(myParam5);

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

        private void Update(User item)
        {

            OleDbParameter myParam1 = new OleDbParameter("@userId", item.Id);

            OleDbParameter myParam2 = new OleDbParameter("@fname", item.FirstName);

            OleDbParameter myParam3 = new OleDbParameter("@lname", item.LastName);

            OleDbParameter myParam4 = new OleDbParameter("@username", item.Username);

            OleDbParameter myParam5 = new OleDbParameter("@pass", item.Password);


            OleDbCommand myCommand = new OleDbCommand(
    @"UPDATE Users SET fname=@fname,lname=@lname,username=@username,pass=@pass WHERE userId=@userId", myconn);

            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);
            myCommand.Parameters.Add(myParam5);

            Console.WriteLine("User updated successfully");

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

        public User GetById(int id)
        {
            User user = new User();

            OleDbParameter myParam1 = new OleDbParameter("@userId", id);

            string oString = @"select * from Users where userId=@userId";
            OleDbCommand oCmd = new OleDbCommand(oString, myconn);
             //or oCmd.Parameters.AddWithValue("@Fname", fName);


            using (OleDbDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    user.FirstName = oReader["fname"].ToString();
                    user.LastName = oReader["lname"].ToString();
                    user.Username = oReader["username"].ToString();
                    user.Password = oReader["password"].ToString();
                }
            }
            try
            {
                myconn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconn.Close();
            }

            return user;
        }

        public void Delete(User item)
        {
            OleDbParameter myParam1 = new OleDbParameter("@userId", item.Id);

            OleDbParameter myParam2 = new OleDbParameter("@fname", item.FirstName);

            OleDbParameter myParam3 = new OleDbParameter("@lname", item.LastName);

            OleDbParameter myParam4 = new OleDbParameter("@username", item.Username);

            OleDbParameter myParam5 = new OleDbParameter("@pass", item.Password);


            OleDbCommand myCommand = new OleDbCommand(
    @"DELETE from Users  WHERE userId=@userId", myconn);

            myCommand.Parameters.Add(myParam1);
            myCommand.Parameters.Add(myParam2);
            myCommand.Parameters.Add(myParam3);
            myCommand.Parameters.Add(myParam4);
            myCommand.Parameters.Add(myParam5);

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

            Console.WriteLine("A User was deleted!");
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            User user = new User();
            OleDbParameter usern = new OleDbParameter("@username",username);

            OleDbParameter pass = new OleDbParameter("@pass",password);

            string oString = @"Select * from Users where username=@username and pass=@pass";
            OleDbCommand oCmd = new OleDbCommand(oString, myconn);
            oCmd.Parameters.Add(usern);
            oCmd.Parameters.Add(pass);

            try
            {
                myconn.Open();
                OleDbDataReader oReader = oCmd.ExecuteReader();

                while (oReader.Read())
                {
                    user.Id = Convert.ToInt32(oReader["userId"]);
                    user.FirstName = oReader["fname"].ToString();
                    user.LastName = oReader["lname"].ToString();
                    user.Username = oReader["username"].ToString();
                    user.Password = oReader["pass"].ToString();
                }

                oReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                myconn.Close();
            }


            return user;
        }

    }    
}