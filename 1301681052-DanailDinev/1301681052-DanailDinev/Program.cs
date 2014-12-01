using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDD
{
    class Program
    {
        //configure this first!
        static string DataSourceURL = "..\\..\\data\\MyDB.accdb";

        static OleDbConnection myConnection;
        static string myTable = "RegisteredUsers";
        static string myRoleTable = "UserRoles";

        static string appHeader = "----------------------------------------------------------- USER ADMINISTRATION -----------------------------------------------------------\n";
        static string loginUsername, loginPassword;
        static string UserRole = "guest";
        
        static void Main(string[] args)
        {
            Console.Title = "User Administration";
            Console.SetBufferSize(140, 90);
            Console.SetWindowSize(140, 35);
            myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+DataSourceURL+"");

            //hacking program begins lol - part 2
            LoginScreen();
        }

        static void LoginScreen()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nLogin screen (leave empty fields for guest session)\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Username: ");
                loginUsername = Console.ReadLine();
                Console.Write("Password: ");
                loginPassword = Console.ReadLine();
                if (!String.IsNullOrEmpty(loginUsername) && !String.IsNullOrEmpty(loginPassword))
                {
                    try
                    {
                        myConnection.Open();
                        OleDbCommand myCommandCheckUserExist = new OleDbCommand("select count(*) FROM " + myTable + " where username=? and password=?", myConnection);
                        myCommandCheckUserExist.Parameters.AddWithValue("@username", loginUsername);
                        myCommandCheckUserExist.Parameters.AddWithValue("@password", loginPassword);
                        bool exists = (int)myCommandCheckUserExist.ExecuteScalar() > 0;
                        if (exists)
                        {
                            //time to check if banned
                            OleDbCommand myCommandCheckBanned = new OleDbCommand("select banned FROM " + myTable + " where username=? and password=?", myConnection);
                            myCommandCheckBanned.Parameters.AddWithValue("@username", loginUsername);
                            myCommandCheckBanned.Parameters.AddWithValue("@password", loginPassword);
                            bool isBanned = (bool)myCommandCheckBanned.ExecuteScalar();
                            myConnection.Close();

                            if (isBanned == true)
                            {
                                ErrorDisplay("Sorry dude, you are BANNED from the system :(");
                                LoginScreen();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\nSuccess!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ReadKey();
                                //time to check usr role
                                CheckUserRole(loginUsername, loginPassword);
                            }
                        }
                        else
                        {
                            ErrorDisplay("Wrong username/password!");
                            LoginScreen();
                        }
                        //Console.ReadKey();
                        //LoginScreen();
                    }
                    catch (OleDbException e)
                    {
                        myConnection.Close();
                        ErrorDisplay(e.Message);
                        LoginScreen();
                    }
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nLogged as guest!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                    UserRole = "guest";
                    Menu();
                }
            }
            catch (Exception e)
            {
                myConnection.Close();
                ErrorDisplay(e.Message);
                LoginScreen();
            }
        }

        static void CheckUserRole(string loginUsername, string loginPasswod)
        {
            try
            {
                //check user role id from RegiteredUsers tabble
                myConnection.Open();
                OleDbCommand myCommandCheckUserRole = new OleDbCommand("select role FROM " + myTable + " where username=? and password=?", myConnection);
                myCommandCheckUserRole.Parameters.AddWithValue("@blq", loginUsername);
                myCommandCheckUserRole.Parameters.AddWithValue("@blq2", loginPassword);
                int role_id = (int)myCommandCheckUserRole.ExecuteScalar();

                //check the role id from UserRoles table
                OleDbCommand myCommandRoleName = new OleDbCommand("select role FROM " + myRoleTable + " where id=?", myConnection);
                myCommandRoleName.Parameters.AddWithValue("@id", role_id);
                UserRole = (string)myCommandRoleName.ExecuteScalar();

                myConnection.Close();
                Menu();
            } 
            catch(Exception e)
            {
                myConnection.Close();
                ErrorDisplay(e.Message);
                ErrorDisplay(e.StackTrace);
                LoginScreen();
            }
        }

        static void Logout()
        {
            UserRole = string.Empty;
            loginUsername = string.Empty;
            loginPassword = string.Empty;
            LoginScreen();
        }

        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(appHeader);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(100, 0);
                Console.WriteLine("Logged user '{0}' as {1}\n", loginUsername, UserRole);
                Console.SetCursorPosition(0, 2);
                Console.ForegroundColor = ConsoleColor.Gray;
                // HARDCODING THE ROLEs!!
                if (UserRole == "guest")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("9. Logout");
                    Console.WriteLine("0. Exit application\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int guest_choice = int.Parse(Console.ReadLine());
                    switch (guest_choice)
                    {
                        case 9:
                            Logout();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Menu();
                            break;
                    }
                }
                else if (UserRole == "member")
                {
                    Console.WriteLine("1. Show all users\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("9. Logout");
                    Console.WriteLine("0. Exit application\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int guest_choice = int.Parse(Console.ReadLine());
                    switch (guest_choice)
                    {
                        case 1:
                            ReadAllUsers();
                            Console.Write("\nPress any key to back to menu ...");
                            Console.ReadKey();
                            Menu();
                            break;
                        case 9:
                            Logout();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Menu();
                            break;
                    }
                }
                else if (UserRole == "admin")
                {
                    Console.WriteLine("1. Show all users");
                    Console.WriteLine("2. Add user");
                    Console.WriteLine("3. Edit user");
                    Console.WriteLine("4. BAN/UNBAN user");
                    Console.WriteLine("5. Delete user\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("9. Logout");
                    Console.WriteLine("0. Exit application\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ReadAllUsers();
                            Console.Write("\n\nPress any key to back to menu ...");
                            Console.ReadKey();
                            Menu();
                            break;
                        case 2:
                            AddUserMenu();
                            break;
                        case 3:
                            EditUserMenu();
                            break;
                        case 4:
                            BanUserMenu();
                            break;
                        case 5:
                            DeleteUserMenu();
                            break;
                        case 9:
                            Logout();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Menu();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorDisplay(e.Message);
                Menu();
            }
        }

        static void ReadAllUsers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(appHeader);

                myConnection.Open();
                OleDbCommand myCommand = new OleDbCommand("SELECT * FROM RegisteredUsers", myConnection);      //показжането на всички потребители
                OleDbCommand myTotalEntries = new OleDbCommand("SELECT COUNT(*) FROM RegisteredUsers", myConnection);  //общо регистрирани
                OleDbDataReader myReader = myCommand.ExecuteReader();
                Console.WriteLine("All users ({0} total):\n\nID |     Username      |      Password     |         Email           |       Realname        | Birthday  |Reg.date  | Role | Confirmed\n", myTotalEntries.ExecuteScalar());
                int i = Console.CursorTop;
                while (myReader.Read())
                {
                    #region writeline...
                    if (myReader.GetBoolean(8) == true)                      // banned
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(myReader.GetInt32(0).ToString());     // ID
                    Console.SetCursorPosition(4, i);
                    Console.WriteLine(myReader.GetString(1));               // username
                    Console.SetCursorPosition(24, i);
                    Console.WriteLine(myReader.GetString(2));               // passwd
                    Console.SetCursorPosition(44, i);
                    Console.WriteLine(myReader.GetString(3));               // email
                    Console.SetCursorPosition(70, i);
                    Console.WriteLine(myReader.GetString(4));               // realname
                    Console.SetCursorPosition(94, i);
                    Console.WriteLine(myReader.GetDateTime(5).ToString("yyyy-MM-dd"));    //bday
                    Console.SetCursorPosition(106, i);
                    Console.WriteLine(myReader.GetDateTime(6).ToString("yyyy-MM-dd"));    //regdate
                    Console.SetCursorPosition(118, i);
                    if (myReader.GetInt32(9) == 1)                      // ROLE
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Admin");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    } else if(myReader.GetInt32(9) == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Member");
                    }
                    Console.SetCursorPosition(126, i);
                    if (myReader.GetBoolean(7) == true)                      // activated 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }                                               
                    Console.SetCursorPosition(133, i);
                    if (myReader.GetBoolean(8) == true)                      // banned
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Banned");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }          
                    i++;
                    #endregion
                }
                myReader.Close();
                myConnection.Close();
            }
            catch (OleDbException e)
            {
                myConnection.Close();
                ErrorDisplay(e.Message);
            }
        }

        static void AddUserMenu()
        {
            try
            {
                string newUserName, newPassword, newEmail, newRealname, newBirthday, newRole , isActivatedInput;
                bool isActivated = false;

                Console.Clear();
                Console.WriteLine(appHeader);
                Console.WriteLine("Add new user \n\n");
                
                    Console.Write("Username (only letters and numbers): ");
                    do { newUserName = Console.ReadLine(); } while (newUserName == "");    // fast check for empty input

                    Console.Write("Password (only letters and numbers): ");
                    do { newPassword = Console.ReadLine(); } while (newPassword == "");

                    Console.Write("Email: ");
                    do { newEmail = Console.ReadLine(); } while (newEmail == "");

                    Console.Write("Name: ");
                    do { newRealname = Console.ReadLine(); } while (newRealname == "");

                    Console.Write("Birthday (YYYY-MM-DD): ");
                    do { newBirthday = Console.ReadLine(); } while (newBirthday == "");

                    Console.Write("Active (y/n): ");
                    isActivatedInput = Console.ReadLine();
                    do
                    {
                        if (isActivatedInput == "y")
                            isActivated = true;
                        else if (isActivatedInput == "n")
                            isActivated = false;
                    } while (isActivatedInput == "");

                    Console.Write("User role ([m]ember / [a]dmin): ");
                    do
                    {
                        // HARDCODING THE ROLE IDs!!
                        newRole = Console.ReadLine();
                        if (newRole == "m")
                        {
                            newRole = "2";
                        }
                        else if (newRole == "a")
                        {
                            newRole = "1";
                        }
                    } while (newRole == "m" || newRole == "a");

                    try
                    {
                        myConnection.Open();
                        OleDbCommand myCommand = new OleDbCommand("INSERT INTO RegisteredUsers (username, `password`, email, realname, birthday, dateregistered, activated, banned, role) values (@newUserName, @newPassword, @newEmail, @newRealname, @birthday, NOW(), @isActivated, FALSE, @role)", myConnection);
                        myCommand.Parameters.AddWithValue("@newUserName", newUserName);
                        myCommand.Parameters.AddWithValue("@newPassword", newPassword);
                        myCommand.Parameters.AddWithValue("@newEmail,", newEmail);
                        myCommand.Parameters.AddWithValue("@newRealname", newRealname);
                        myCommand.Parameters.AddWithValue("@newBirthday", newBirthday);
                        myCommand.Parameters.AddWithValue("@isActivated", isActivated);
                        myCommand.Parameters.AddWithValue("@role", newRole);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSuccesfully added user!\n\nPress any key to back to menu ...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Menu();
                    }
                    catch (OleDbException e)
                    {
                        myConnection.Close();
                        ErrorDisplay(e.Message);
                    }
            
            }
            catch (Exception e)
            {
                ErrorDisplay(e.Message);
            }
        }

        static void EditUserMenu()
        {
            try
            {
                ReadAllUsers();

                // target id
                Console.Write("\n\nSelect ID you want to change ('0' - back to menu): ");
                int id = int.Parse(Console.ReadLine());
                if (id != 0)
                {
                    // show target info
                    myConnection.Open();
                    OleDbCommand myCommandSelectID = new OleDbCommand("SELECT * FROM RegisteredUsers WHERE ID=@id", myConnection);
                    myCommandSelectID.Parameters.AddWithValue("@id", id);
                    OleDbDataReader myReader = myCommandSelectID.ExecuteReader();
                    while (myReader.Read())
                    {
                        Console.WriteLine("\nID: {0}\n1) username: {1}\n2) password: {2}\n3) email: {3}\n4) Realname: {4}\n5) birthday: {5}\n6) active: {6}", myReader.GetInt32(0).ToString(), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetDateTime(6).ToString("yyyy-MM-dd"), myReader.GetBoolean(7));
                        // HARDCODING THE ROLE IDs!!
                        if(myReader.GetInt32(9).ToString() ==  "1")
                        {
                            Console.WriteLine("7) role: admin");
                        } else if(myReader.GetInt32(9).ToString() ==  "2")
                        {
                            Console.WriteLine("7) role: member");
                        }
                    }
                    myReader.Close();
                    myConnection.Close();

                    // pick value to change
                    int choice;
                    string newValue;
                    do
                    {
                        Console.Write("\n\nValue you want to change (write digit or '0' to change id): ");
                        choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.Write("\nWrite new username: ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("username", newValue, id);
                        }
                        else if (choice == 2)
                        {
                            Console.Write("\nWrite new password: ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("password", newValue, id);
                        }
                        else if (choice == 3)
                        {
                            Console.Write("\nWrite new email: ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("email", newValue, id);
                        }
                        else if (choice == 4)
                        {
                            Console.Write("\nWrite new name: ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("realname", newValue, id);
                        }
                        else if (choice == 5)
                        {
                            Console.Write("\nWrite new birthday(yyyy-mm-dd): ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("birthday", newValue, id);
                        }
                        else if (choice == 6)
                        {
                            Console.Write("\nIs user activated by email? (true/false): ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("activated", newValue, id);
                        }
                        else if (choice == 7)
                        {
                            Console.Write("\nChange user role ([m]ember/[a]dmin): ");
                            do { newValue = Console.ReadLine(); } while (newValue == "");
                            EditUserCommand("role", newValue, id);
                        }
                        else if (choice == 0)
                        {
                            EditUserMenu();
                            Console.ReadKey();
                        }
                    } while (choice != 0);
                }
                else { Menu(); }
            }
            catch (Exception e)
            {
                myConnection.Close();
                ErrorDisplay(e.Message);
                ErrorDisplay(e.StackTrace);
                Menu();
            }
        }

        static void EditUserCommand(string type, string newValue, int id)
        {
            string actionTypeString = "";  //tuk se suhranqva imeto na deistvieto 

            //Console.WriteLine("\nentered values: {0}={1} / id={2}\n", type, newValue, id);
            try
            {           
                myConnection.Open();
                if (type == "password")  //                     V  different types - different queries  V
                {
                    actionTypeString = "changed user password!";
                    OleDbCommand myCommand = new OleDbCommand("UPDATE RegisteredUsers SET `password`='" + newValue + "' WHERE ID=" + id + "", myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                else if (type == "activated" || type == "banned")
                {
                    actionTypeString = " changed value";
                    OleDbCommand myCommand = new OleDbCommand("UPDATE RegisteredUsers SET " + type + "=" + newValue + " WHERE ID=" + id + "", myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                else
                {
                    actionTypeString = "edited user info!";
                    OleDbCommand myCommand = new OleDbCommand("UPDATE RegisteredUsers SET " + type + "='" + newValue + "' WHERE ID=" + id + "", myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSuccesfully {0}", actionTypeString);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (OleDbException e)
            {
                myConnection.Close();
                ErrorDisplay(e.Message);
            }
        }

        static void BanUserMenu()
        {
            try
            {
                bool isBanned = false;

                ReadAllUsers();

                // target id
                Console.Write("\nSelect ID you want to BAN/UNBAN ('0' back to menu): ");
                int id = int.Parse(Console.ReadLine());
                if (id != 0)
                {
                    // check if banned and shows some basic info
                    myConnection.Open();
                    OleDbCommand myCommandSelectID = new OleDbCommand("SELECT * FROM RegisteredUsers WHERE ID=@id", myConnection);
                    myCommandSelectID.Parameters.AddWithValue("@id", id);
                    OleDbDataReader myReader = myCommandSelectID.ExecuteReader();
                    while (myReader.Read())
                    {
                        if(myReader.GetBoolean(8) == true)
                        {
                            isBanned = true;
                        }
                        else
                        {
                            isBanned = false;
                        }
                        Console.Write("\nid: {0} usrname: {1} \n\n ", myReader.GetInt32(0).ToString(), myReader.GetString(1));
                    }
                    myReader.Close();
                    myConnection.Close();


                    if(isBanned == true)
                    {
                        Console.Write("Do you want to UNBAN this user? (y/n) ");
                        string choice = Console.ReadLine();
                        do
                        {
                            if(choice == "y")
                            {
                                EditUserCommand("banned", "false", id);
                                Console.ReadLine();
                                BanUserMenu();
                            } 
                            else if(choice == "n")
                            {
                                Console.WriteLine("\nYour choice was 'NO'. Press any key to continue ...");
                                Console.ReadLine();
                                BanUserMenu();
                            }
                        } while (choice == "");
                    }
                    else if(isBanned == false)
                    {
                        Console.Write("Do you want to BAN this user? (y/n) ");
                        string choice = Console.ReadLine();
                        do
                        {
                            if (choice == "y")
                            {
                                EditUserCommand("banned", "true", id);
                                Console.WriteLine("");
                                Console.ReadKey();
                                BanUserMenu();
                            }
                            else if (choice == "n")
                            {
                                Console.WriteLine("\nYour choice was 'NO'. Press any key to continue ...");
                                Console.ReadLine();
                                BanUserMenu();
                            }
                        } while (choice == "");
                    }
                }
                else { Menu(); }
            }
            catch (Exception e)
            {
                myConnection.Close();
                ErrorDisplay(e.StackTrace);
            }
        }

        static void DeleteUserMenu()
        {
            try
            {
                ReadAllUsers();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nID you want to delete ('0' - back to menu): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice != 0)
                {
                    try
                    {
                        myConnection.Open();
                        OleDbCommand myCommand = new OleDbCommand("DELETE FROM RegisteredUsers WHERE ID = @id", myConnection);
                        myCommand.Parameters.AddWithValue("@id", choice);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSuccesfully deleted user!\n\nPress any key to back to menu ...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Menu();
                    }
                    catch (OleDbException e)
                    {
                        myConnection.Close();
                        ErrorDisplay(e.Message);
                    }
                }
                else { Menu(); }
            }
            catch (Exception e)
            {
                ErrorDisplay(e.Message);
            }
        }

        static void ErrorDisplay(string e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nApplication error: {0}\n\nPress any key to back to menu ...", e);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
