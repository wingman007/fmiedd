using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAccessConsole
{
    class Program
    {
        static OleDbConnection aConnection;
        static void Main(string[] args)
        {
            aConnection =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fmi\Desktop\1301681022_Janeta_Stanilova\Users.accdb");
            int input = 0;
            while (true)
            {
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Registered");
            Console.WriteLine("2. Not registered");
            Console.WriteLine("3. Exit\n");
            Console.Write("Please tell us if you are already registered or not: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Console.WriteLine("\n1. Please log in");
                    Identification(); break;
                case 2:
                    Console.WriteLine("\n2. Please sign up");
                    Insert(); break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nPlease choose a number from 1 to 3!\n");
                    break;
            }
            input++;
            if (input < 30)
                continue;
            else
                break;
            }
        }
            public static void Menu()
            {
            int input = 0;
            while (true)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Database");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update username");
                Console.WriteLine("4. Update password");
                Console.WriteLine("5. Update email");
                Console.WriteLine("6. Update role");
                Console.WriteLine("7. Delete");
                Console.WriteLine("8. Exit\n");
                Console.Write("Please choose wisely: ");
                int menuchoice = int.Parse(Console.ReadLine());
                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("\n1. Database");
                        Retrieve(); break;
                    case 2:
                        Console.WriteLine("\n2. Insert");
                        Insert(); break;
                    case 3:
                        Console.WriteLine("\n3. Update username");
                        UpdateUsername(); break;
                    case 4:
                        Console.WriteLine("\n4. Update password");
                        UpdatePassword(); break;
                    case 5:
                        Console.WriteLine("\n5. Update email");
                        UpdateEmail(); break;
                    case 6:
                        Console.WriteLine("\n6. Update role");
                        UpdateRole(); break;
                    case 7:
                        Console.WriteLine("\n7. Delete");
                        Delete(); break;
                    case 8:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nPlease choose a number from 1 to 8!");
                        break;
                }
                input++;
                if (input < 30)
                    continue;
                else
                    break;
            }
            }
            public static void Retrieve()
            {
            OleDbCommand aCommand = new OleDbCommand("SELECT * from users", aConnection);
            try
            {
                aConnection.Open();
                OleDbDataReader aReader = aCommand.ExecuteReader();
                Console.WriteLine("\nThis is the returned data from users table\n");
                while (aReader.Read())
                {
                    Console.WriteLine(" ID: {0} \n Username: {1} \n Password: {2} \n Email: {3} \n Role: {4} \n", aReader.GetInt32(0).ToString(), aReader.GetString(1), aReader.GetString(2), aReader.GetString(3), aReader.GetValue(4));
                }
                aReader.Close();
                aConnection.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
            }
        public static void Insert()
        {
            string username, password, email;
            int role_id;
            Console.Write("Please type your username: ");
            username = Console.ReadLine();
            Console.Write("Please type your password: ");
            password = Console.ReadLine();
            Console.Write("Please type your email: ");
            email = Console.ReadLine();
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Member");
            Console.WriteLine("2. Admin");
            Console.Write("\nPlease choose your role: ");
            role_id = int.Parse(Console.ReadLine());
            if (role_id == 2)
            {
                string pass;
                do
                {
                    Console.Write("\nPlease type the admin password: ");
                    pass = Console.ReadLine();
                    if (pass != "adminpassword")
                    {
                        Console.WriteLine("\nWrong password!");
                    }
                } while (pass != "adminpassword");
            }
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("INSERT INTO users (username, `password`, email, role_id) VALUES (@par1, @par2, @par3, @par4)", aConnection);
                aCommand.Parameters.AddWithValue("@par1", username);
                aCommand.Parameters.AddWithValue("@par2", password);
                aCommand.Parameters.AddWithValue("@par3", email);
                aCommand.Parameters.AddWithValue("@par4", role_id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Insert", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void UpdateUsername()
        {
            int id;
            string username;
            Console.Write("Please type the ID to the record you want to change: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Please type the new username: ");
            username = Console.ReadLine();
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET username = @par1 WHERE ID = @param1", aConnection);
                aCommand.Parameters.AddWithValue("@par1", username);
                aCommand.Parameters.AddWithValue("@param1", id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Update", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void UpdatePassword()
        {
            int id;
            string password;
            Console.Write("Please type the ID to the record you want to change: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Please type the new password: ");
            password = Console.ReadLine();
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET `password` = @par2 WHERE ID = @param2", aConnection);
                aCommand.Parameters.AddWithValue("@par2", password);
                aCommand.Parameters.AddWithValue("@param2", id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Update", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void UpdateEmail()
        {
            int id;
            string email;
            Console.Write("Please type the ID to the record you want to change: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Please type the new email: ");
            email = Console.ReadLine();
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET email = @par3 WHERE ID = @param3", aConnection);
                aCommand.Parameters.AddWithValue("@par3", email);
                aCommand.Parameters.AddWithValue("@param3", id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Update", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void UpdateRole()
        {
            int id, role_id;
            Console.Write("Please type the ID to the record you want to change: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Choose your new role - 1. Member or 2. Admin: ");
            role_id = int.Parse(Console.ReadLine());
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("UPDATE users SET role_id  = @par5 WHERE ID = @param5", aConnection);
                aCommand.Parameters.AddWithValue("@par5", role_id);
                aCommand.Parameters.AddWithValue("@param5", id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Update", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void Delete()
        {
            int id;
            Console.Write("Please type the ID to the record you want to delete: ");
            id = int.Parse(Console.ReadLine());
            try
            {
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand("DELETE FROM users WHERE ID = @param4", aConnection);
                aCommand.Parameters.AddWithValue("@param4", id);
                int numAffectedRows = aCommand.ExecuteNonQuery();
                aConnection.Close();
                Console.WriteLine("Number of records affected {0} from Delete", numAffectedRows);
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error: {0}", e.Errors[0].Message);
            }
        }
        public static void Identification()
        {
            string username, password;
            Console.Write("Please type your username: ");
            username = Console.ReadLine();
            Console.Write("Please type your password: ");
            password = Console.ReadLine();
            int input = 0;
            while (true)
            {
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Member");
            Console.WriteLine("2. Admin");
            Console.Write("\nPlease choose your role: ");
            int role_id = int.Parse(Console.ReadLine());
            switch (role_id)
            {
                case 1:
                    Console.WriteLine("\n1. Member");
                    Retrieve(); break;
                case 2:
                    Console.WriteLine("\n2. Admin");
                    string pass;
                    Console.Write("Please type the admin password: ");
                    pass = Console.ReadLine();
                    if (pass != "adminpassword")
                    {
                        Console.WriteLine("\nWrong password!");
                    }
                    else Menu(); break;
                default:
                    Console.WriteLine("\nPlease choose a number from 1 to 2!\n");
                    break;
            }
            input++;
            if (input < 30)
                continue;
            else
                break;
            }
        }
    }
}
