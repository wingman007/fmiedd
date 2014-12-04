using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.Entity;
using projectWeek10.Service;

namespace projectWeek10.Repository
{
    public class TableRepository
    {
        static SqlConnection aConnection;
        public static void Table()
        {
            aConnection = new SqlConnection(@"Data Source=VELKO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=data");


            SqlCommand aCommand = new SqlCommand("SELECT * from users", aConnection);
            try
            {
                aConnection.Open();

                SqlDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("This is the returned data from test table");
                while (aReader.Read())
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3),aReader.GetInt32(4).ToString());
                }

                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("###############################################################");
        }
        public static void TableMember()
        {
            aConnection = new SqlConnection(@"Data Source=VELKO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=data");

            User user = new User();

            SqlCommand aCommand = new SqlCommand("SELECT * from users where [id] = " + AuthenticationService.LoggedUser.Id, aConnection);
            try
            {
                aConnection.Open();

                SqlDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("Because you are just a member , you can only update ! ");
                while (aReader.Read())
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} ", aReader.GetInt32(0), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3), aReader.GetInt32(4));
                }

                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("###############################################################");
        }

        public static void Add()
        {


            Console.Clear();

            Repository.TableRepository.Table();


            Console.WriteLine("ДОБАВЯВНЕ НА ЗАПИС ");
            Console.WriteLine("МОЛЯ първо проверете дали ID - то съществува !!!");

            Console.Write("id : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Име : ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Парола : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write("Email : ");
            string email = Convert.ToString(Console.ReadLine());

            Console.Write("RoleID : ");
            int roleID = Convert.ToInt32(Console.ReadLine());




            try
            {
                aConnection.Open();

                SqlCommand aCommand = new SqlCommand("INSERT INTO [users] ([id], [username], [password], [email],[role_id]) VALUES('" + ID + "','" + name + "','" + password + "','" + email + "','" + roleID + "')", aConnection);
                aCommand.ExecuteNonQuery();             
            

                aConnection.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Такова ID или RoleID вече съществува ! ");
                Console.ReadKey(true);
                aConnection.Close();
                Console.Clear();
                return;
            }

            Console.WriteLine("Добавихте запис с номер  {0} успешно", ID);
            Console.ReadKey(true);
            Console.Clear();
            return;

        }

        public static void Delete()
        {
            Console.Clear();
            Repository.TableRepository.Table();

            Console.WriteLine("ИЗТРИВАНЕ НА ЗАПИС");
            Console.WriteLine("МОЛЯ първо проверете дали ID - то съществува !!!");


            Console.Write("Номер на запис ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());


            try
            {

                aConnection.Open();
                SqlCommand aCommand = new SqlCommand("DELETE FROM users WHERE id = " + ID, aConnection);



                aCommand.ExecuteNonQuery();

                aConnection.Close();

            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                Console.ReadKey(true);
                Console.Clear();
                aConnection.Close();
                return;
            }


            Console.WriteLine("Изтрихте запис с номер {0} успешно  !!!", ID);
            Console.ReadKey(true);
            Console.Clear();
            aConnection.Close();
            return;
        }


        public static void Update()
        {
            Console.Clear();

            Repository.TableRepository.Table();

            Console.WriteLine("ОБНОВЯВАНЕ НА ЗАПИС");
            Console.WriteLine("МОЛЯ първо проверете дали ID - то съществува !!!");

            Console.Write("Номер на запис ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Име : ");
            string username = Convert.ToString(Console.ReadLine());

            Console.Write("Парола : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write("Email : ");
            string email = Convert.ToString(Console.ReadLine());

            Console.Write("RoleID : ");
            int roleID = Convert.ToInt32(Console.ReadLine());



            try
            {
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand("UPDATE [users] SET [username]='" + username + "',[password]='" + password + "',[email]='" + email + "',[role_id]='" + roleID +"'where [id]=" + ID, aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("Променихте запис с номер {0}  успешно", ID);
            Console.ReadKey(true);
            Console.Clear();

            return;
        }
        public static void UpdateMember()
        {
            Console.Clear();

            Repository.TableRepository.TableMember();

            Console.WriteLine("ОБНОВЯВАНЕ НА ЗАПИС");
            Console.WriteLine("МОЛЯ първо проверете дали ID - то съществува !!!");


            Console.Write("Име : ");
            string username = Convert.ToString(Console.ReadLine());

            Console.Write("Парола : ");
            string password = Convert.ToString(Console.ReadLine());

            Console.Write("Email : ");
            string email = Convert.ToString(Console.ReadLine());




            try
            {
                aConnection.Open();
                SqlCommand aCommand = new SqlCommand("UPDATE [users] SET [username]='" + username + "',[password]='" + password + "',[email]='" + email + "'where [ID]=" + AuthenticationService.LoggedUser.Id , aConnection);
                aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
                aConnection.Close();
            }

            Console.WriteLine("Променихте запис с номер {0}  успешно", username);
            Console.ReadKey(true);
            Console.Clear();

            return;
        }

    }  
}
