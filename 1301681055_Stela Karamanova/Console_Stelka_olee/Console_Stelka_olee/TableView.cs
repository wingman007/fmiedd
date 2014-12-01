﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Stelka_olee.Tools;

namespace Console_Stelka_olee.View
{
    public class TableView
    {
        static OleDbConnection aConnection;

        public void Show()
        {
            aConnection = new OleDbConnection("Provider=SQLNCLI11;Data Source=STELKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Users");


            Console.Clear();



            while (true)
            {
                Console_Stelka_olee.Repository.TableRepository.Table();

                Menu choice = RenderMenu();

                switch (choice)
                {

                    case Menu.Insert:
                        {
                            Add();
                            break;
                        }
                    case Menu.Update:
                        {
                            Update();
                            break;
                        }
                    case Menu.Delete:
                        {
                            Delete();
                            break;
                        }
                    case Menu.Exit:
                        {
                            return;
                        }
                }
            }
        }



        private Menu RenderMenu()
        {
            while (true)
            {

                Console.WriteLine("[A]dd ");
                Console.WriteLine("[U]pdate");
                Console.WriteLine("[D]elete ");
                Console.WriteLine("E[x]it");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {

                    case "A":
                        {
                            return Menu.Insert;
                        }
                    case "U":
                        {
                            return Menu.Update;
                        }
                    case "D":
                        {
                            return Menu.Delete;
                        }
                    case "X":
                        {
                            return Menu.Exit;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice! ");
                            Console.ReadKey(true);
                            break;
                        }
                }
            }
        }


        public static void Add()
        {

            Console.Clear();

            Console_Stelka_olee.Repository.TableRepository.Table();


            Console.WriteLine("Adding a object ");
            Console.WriteLine("ID first!!!");

            Console.Write("id : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fname : ");
            string fname = Convert.ToString(Console.ReadLine());

            Console.Write("Lname : ");
            string lname = Convert.ToString(Console.ReadLine());

            Console.Write("Password : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write("Email : ");
            string email = Convert.ToString(Console.ReadLine());



            try
            {
                aConnection.Open();



                OleDbCommand aCommand = new OleDbCommand("INSERT INTO [users] ([id], [fname],[lname], [password], [email]) VALUES('" + ID + "','" + fname +"','" + lname +  "','" + password + "','" + email + "')", aConnection);
                aCommand.ExecuteNonQuery();



                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }


            Console.WriteLine("Adding object with number {0} successful", ID);
            Console.Clear();
            return;

        }

        public static void Delete()
        {
            Console.Clear();
            Console_Stelka_olee.Repository.TableRepository.Table();

            Console.WriteLine("Delete");
            Console.WriteLine("Check and select the ID first !!!");

            Console.Write("Number of ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE id = " + ID, aConnection);

                aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("Delete object  {0}  successful", ID);
            Console.Clear();

            return;


        }
        public static void Update()
        {
            Console.Clear();

            Console_Stelka_olee.Repository.TableRepository.Table();

            Console.WriteLine("Update object");
            Console.WriteLine("Check the ID first !!!");

            Console.Write("Number of object ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fname : ");
            string fname = Convert.ToString(Console.ReadLine());

            Console.Write("Lname : ");
            string lname = Convert.ToString(Console.ReadLine());

            Console.Write("Password : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write("Email : ");
            string email = Convert.ToString(Console.ReadLine());



            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("UPDATE [users] SET [fname]='" + fname + "',[lname]='" + lname + "',[password]='" + password + "',[email]='" + email + "'where [id]=" + ID, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("Change object with number {0} successful", ID);
            Console.Clear();
            return;
        }

    }
}
