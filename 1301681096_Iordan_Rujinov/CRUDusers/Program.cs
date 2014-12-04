using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDusers
{
    class Program
    {
        static OleDbConnection aConnection;
        public static int role = 0;
        static void Main(string[] args)
        {
            aConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Iordan\Desktop\CRUDusers\CRUDusers\data\users.accdb");
                Console.WriteLine("Въведете Никнейм и Парола на латиница");
                Console.Write("Никнейм : ");
                string username = Console.ReadLine();
                Console.Write("Парола : ");
                string password = Console.ReadLine();
                role = getRole(username, password);
                if (true)
                {
                    
                }
                if (login(username, password))
                {
                    Read();
                    while (true)
                    {
                        Console.WriteLine("Изберете една от следните опции: <A>ДОБАВЯНЕ <U>ПРОМЯНА <D>ИЗТРИВАНЕ <E>ИЗХОД");
                        string action = Console.ReadLine();
                        Console.WriteLine();
                        switch (action)
                        {

                            case "A":
                                Console.WriteLine("Въведете следните данни: потребител, парола, ел.поща и роля");
                                try
                                {
                                    if (role==1)
                                    {  
                                    Console.Write("Въведете никнейм: ");
                                    string userAdd = Console.ReadLine();
                                    Console.Write("Въведете парола: ");
                                    string passAdd = Console.ReadLine();
                                    Console.Write("Въведете ел.поща: ");
                                    string emailAdd = Console.ReadLine();
                                    Console.Write("Въведете роля: ");
                                    string roleAdd = Console.ReadLine();
                                    Console.WriteLine();
                                    Add(userAdd, passAdd, emailAdd);
                                    Read();
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----НЯМАТЕ ПРАВОМОЩИЯ ДА ПРАВИТЕ ТЕЗИ ПРОМЕНИ-----");
                                    }
                                    
                                }
                                catch (OleDbException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;

                            case "U":
                                Console.Write("Коя позиция искате да промените? ");
                                try
                                {
                                    if (role==1)
                                    {
                                        int idUpdate = int.Parse(Console.ReadLine());
                                        Console.Write("Нов никнейм: ");
                                        string usernameUpdate = Console.ReadLine();
                                        Console.Write("Нова парола: ");
                                        string passUpdate = Console.ReadLine();
                                        Console.Write("Нова ел.поща: ");
                                        string emailUpdate = Console.ReadLine();
                                        Console.Write("Въведете роля: ");
                                        int roleUpdate = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        Update(idUpdate, usernameUpdate, passUpdate, emailUpdate, roleUpdate);
                                        Read();

                                    }
                                    else
                                    {
                                        Console.WriteLine("-----НЯМАТЕ ПРАВОМОЩИЯ ДА ПРАВИТЕ ТЕЗИ ПРОМЕНИ-----"); // искам да добавя други функции
                                    }
                               }
                                
                                catch (OleDbException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;

                            case "D":
                                Console.WriteLine("Кой ред искате да изтриете? ");
                                try
                                {
                                    if (role==1)
                                    {
                                        int deleteLine = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        Delete(deleteLine);
                                        Read();
                                    }
                                    else
                                    {
                                        Console.WriteLine("-----НЯМАТЕ ПРАВОМОЩИЯ ДА ПРАВИТЕ ТЕЗИ ПРОМЕНИ-----"); // искам да добавя други функции
                                    }
                                    
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case "E":
                                Environment.Exit(0);
                                break;
                        }

                    }
                    
                }
                else {
                    Console.WriteLine("Сгрешен никнейм или парола");
                     }
                Console.ReadKey(true);
            
        }
        public static bool login(string username, string password) { 
            OleDbCommand selectUser = new OleDbCommand("SELECT COUNT(*) FROM users WHERE username=@username AND password=@password");
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@username", username) });
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@password", password) });
            aConnection.Open();
           
            selectUser.Connection = aConnection;
            try
            {
                int numberOfRows = (int)selectUser.ExecuteScalar();
                if (numberOfRows == 1)
                {
                    aConnection.Close();
                    return true;
                }
                else
                {
                    aConnection.Close();
                    return false;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            aConnection.Close();
            return false;
        }
        public static int getRole(string username, string password)
        {
            int role_id = 0;
            OleDbCommand selectUser = new OleDbCommand("SELECT * FROM users WHERE username=@username AND password=@password", aConnection);
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@username", username) });
            selectUser.Parameters.AddRange(new[] { new OleDbParameter("@password", password) });
            aConnection.Open();
            OleDbDataReader reader = selectUser.ExecuteReader();
            while (reader.Read())
            {
                role_id = reader.GetInt32(4);
            }
            aConnection.Close();
            return role_id;

        }
        public static void Add(string username, string pass, string email)
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO users (username, [password], email, role) VALUES (@par1,@par2,@par3,@part4)", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par2", pass) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par3", email) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par4", role) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("_____{0} реда от INSERT бяха въведени_____", numberOfRows);
                Read();
                Console.WriteLine("_____Потребител с никнейм {0} беше успешно въведен!_____", username);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }

        public static void Update(int ID, string username, string pass, string email, int role)
        {
            try
            {
                aConnection.Open();

                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = @par2, [password] = @par3, role = @part5, email = @par4 WHERE ID = @par1", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par5", role) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par2", username) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par3", pass) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par4", email) });
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", ID) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("_____{0} ред от UPDATE бяха променени_____", numberOfRows);
                Read();
                Console.WriteLine("_____ Потребител с ИД: {0} беше променен_____", ID);
            }
            catch (OleDbException e)
            {
                aConnection.Close();
                Console.WriteLine("Error: {0}", e.Errors[0].Message);

            }
        }

        public static void Delete(int ID)
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE ID = @par1", aConnection);
                aCommand.Parameters.AddRange(new[] { new OleDbParameter("@par1", ID) });
                int numberOfRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("_____ {0} реда от DELETE бяха изтрити_____", numberOfRows);
                Read();
                Console.WriteLine("_____Потребител с номер {0} беше успешно изтрит_____", ID);

            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);

            }

        }
        public static void Read()
        {
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("SELECT * from users", aConnection);
                OleDbDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("Потребители:");
                while (aReader.Read())
                {
                    Console.WriteLine("{0} \t {1}", aReader.GetInt32(0).ToString(), aReader.GetString(1));
                }
                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
    }
}
