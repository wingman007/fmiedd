using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CRUD2.Models;

namespace CRUD2.Models
{
    public class Repo : Connection
    {

        //INSERT into table
        public void INSERT(Users U)
        {
            try
            {
                // Open the connection
                OpenConnection();
                com = new SqlCommand("INSERT INTO USERS (ID,Username,Password,Firstname,Lastname,Email)Values(@v1, @v2, @v3, @v4, @v5,@v6)", conn);
                com.Parameters.AddWithValue("@v1", U.ID);
                com.Parameters.AddWithValue("@v2", U.Username);
                com.Parameters.AddWithValue("@v3", U.Password);
                com.Parameters.AddWithValue("@v4", U.Firstname);
                com.Parameters.AddWithValue("@v5", U.Lastname);
                com.Parameters.AddWithValue("@v6", U.Email);

                com.ExecuteNonQuery();

                com = new SqlCommand("INSERT INTO ROLES (role_id,role)Values(@v1, @v2)", conn);
                com.Parameters.AddWithValue("@v1", U.role_id);
                com.Parameters.AddWithValue("@v2", U.role);

                com.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        //UPDATE
        public void UPDATE(Users U)
        {
            try
            {
                OpenConnection();
                com = new SqlCommand("update Users set Username=@v1,Password=@v2, Firstname=@v3, Lastname=@v4, Email=@v5 where ID=@ID", conn);

                com.Parameters.AddWithValue("@v1", U.Username);
                com.Parameters.AddWithValue("@v2", U.Password);
                com.Parameters.AddWithValue("@v3", U.Firstname);
                com.Parameters.AddWithValue("@v4", U.Lastname);
                com.Parameters.AddWithValue("@v5", U.Email);
                com.Parameters.AddWithValue("@ID", U.ID);


                com.ExecuteNonQuery();

                com = new SqlCommand("update Users set role=@v1 where role_id=@role_id", conn);
                com.Parameters.AddWithValue("@v1", U.role_id);
                com.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }



        }
        //DELETE
        public void DELETE(Users U)
        {
            try
            {
                OpenConnection();
                com = new SqlCommand("delete from Users where ID=@ID", conn);
                com.Parameters.AddWithValue("@ID", U.ID);



                com.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();

            }
        }

        //Method for getting user by id
        //public Users GetByID(int ID)
        //{
        //    try
        //    {
        //        OpenConnection();
        //        com = new SqlCommand("select * from Users where ID=@v1 ", conn);
        //        com.Parameters.AddWithValue("@v1", ID);

        //        Users U = null;

        //        if (dreader.Read())
        //        {
        //            U = new Users();

        //            U.ID = Convert.ToInt32(dreader["ID"]);
        //            U.Password = Convert.ToString(dreader["Password"]);
        //            U.Username = Convert.ToString(dreader["Username"]);
        //            U.Firstname = Convert.ToString(dreader["Firstname"]);
        //            U.Lastname = Convert.ToString(dreader["Lastname"]);
        //            U.Email = Convert.ToString(dreader["Email"]);
        //            U.role_id = Convert.ToInt32(dreader["role_id"]);
        //            U.role = Convert.ToString(dreader["role"]);


        //        }
        //        return U;


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();

        //    }


        //}

        //Method to list all users
        public List<Users> List()
        {
            try
            {
                OpenConnection();
                com = new SqlCommand("select * from Users join Roles on id=role_id", conn);
                dreader = com.ExecuteReader();

                List<Users> list1 = new List<Users>();

                while (dreader.Read())
                {
                    Users U = new Users();

                    U.ID = Convert.ToInt32(dreader["ID"]);
                    U.Username = Convert.ToString(dreader["Username"]);
                    U.Password = Convert.ToString(dreader["Password"]);
                    U.Firstname = Convert.ToString(dreader["Firstname"]);
                    U.Lastname = Convert.ToString(dreader["Lastname"]);
                    U.Email = Convert.ToString(dreader["Email"]);
                    U.role = Convert.ToString(dreader["role"]);


                    list1.Add(U);
                }

                return list1;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public string GetByUserNameAndPassword(string name, string password)
        {
            try
            {
                OpenConnection();
                com = new SqlCommand("Select Username,Password,role from Users join Roles on ID=role_id", conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users();
                    user.Username = reader.GetString(0);
                    user.Password = reader.GetString(1);
                    user.role = reader.GetString(2);
                    if (user.Username == name && user.Password == password && user.role == "admin")
                        return "admin";
                    if (user.Username == name && user.Password == password && user.role == "member")
                        return "member";
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }




    }
}