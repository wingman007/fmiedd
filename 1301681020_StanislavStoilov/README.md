Инструкции за създаване на приложение за връзка с база данни:

1. За да създадете нова база данни, стартирате SQL Management Studio.

2. След като стартирате програмата, натискате New Query и след това създавате самата таблица.

Пример:

CREATE DATABASE PROJECT - създава самата база данни

USE PROJECT

CREATE TABLE USERS - създава таблицата
(

	ID INT PRIMARY KEY,
	USERNAME VARCHAR(50) NOT NULL,
	PASSWORD VARCHAR(30) NOT NULL,
	EMAIL VARCHAR(30) NOT NULL

	)

                 ALTER TABLE USERS
	ADD Role_ID INT


	CREATE TABLE ROLE
	(

                  ID INT FOREIGN KEY REFERENCES USERS NOT NULL,
                  Role VARCHAR(10) NOT NULL

	)

3. След като сте създали базата данни, стартирате Microsoft Visual Studio 2013.

4. Натискате New Project –> Console Application.

5. За да може да боравите с SQL база данни, трябва да най-отгоре в програмата да напишете using.System.Data.SqlClient.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

6. След това, за да можете да осъществите връзка с базата данни, трябва да използвате класа SqlConnection,
   чрез който да укажите името на SQL сървъра и името на базата данни.

Пример:

SqlConnection sqlcon = new SqlConnection("Server=името на сървъра; Database=името на базата; Integrated Security=true; Persist Security Info=false;");
sqlcon.Open();

 Забележка: 

 За да може програмата да работи на различни сървъри, се пише следния код:

SqlConnection sqlcon = new SqlConnection(@"Data Source=името на сървъра; Initial Catalog=името на базата данни; User ID=MyUserID; Password=MyPassword;");
sqlcon.Open();


7. Сега, за да извършвате операциите Insert, Update и Delete, трябва да използвате класа SqlCommand и чрез синтаксиса на SQL, да зададете
    коя операция да се изпълнява. Операциите Insert, Update и Delete е добре да се направят като външни методи и само да се извикват 
    в главната програма. 

Пример:

          class Program
       {

          public static void Insert()
        {

            string id;
            Console.Write("\n\n\t\t ID:");
            id = Console.ReadLine();

            string username;
            Console.Write("\n\t\t Username:");
            username = Console.ReadLine();

            if (username == "")
            {
                Console.WriteLine("\n The username cannot be empty!");
            }

            else
                if (username.Length < 5)
                {
                    Console.WriteLine("\n The username is too short!");
                }

                else
                    if (username != "" && username.Length >= 5)
                    {
                        string password;
                        Console.Write("\n\t\t Password:");
                        password = Console.ReadLine();

                        if (password == "")
                        {

                            Console.WriteLine("\n The password cannot be empty!");
                        }

                        else
                            if (password.Length < 5)
                            {
                                Console.WriteLine("\n The password must be betwen 5 and 15 symbols!");
                            }

                            else
                                if (password != "" && password.Length >= 5 || password.Length <= 15)
                                {
                                    string email;
                                    Console.Write("\n\t\t Email:");
                                    email = Console.ReadLine();

                                    if (email == "")
                                    {
                                        Console.WriteLine("\n The email cannot be empty!");
                                    }

                                    else
                                        if (email != "")
                                        {
                                            int role_id;
                                            Console.Write("\n\t\t Role_ID:");
                                            role_id = int.Parse(Console.ReadLine());

                                        if (role_id == 1 || role_id == 2) - Тези променливи се дефинират, с цел да можем през конзолата да въвеждаме данните,
				                          които искаме да бъдат вкарани в таблицата.
                                        { 

			SqlConnection sqlcon = new SqlConnection("Server=името на сървъра; Database=името на базата; Integrated Security=true; Persist Security Info=false;");
			sqlcon.Open();

                		SqlCommand sqlcom = new SqlCommand("INSERT INTO [PROJECT].[dbo].[USERS] (ID, USERNAME, PASSWORD, EMAIL, Role_ID)" + "VALUES(@ID, @USERNAME, @PASSWORD, @EMAIL, @Role_ID)", sqlcon);

              			 малко уточнение - ако искате да задавате стойностите, които ще се въвеждат в таблицата през конзолата,  използвайте параметри(@USERNAME);

			sqlcom.Parameters.Add("@ID", id); - укзава параметъра и стойността, която той ще приеме. В случая на екрана ще се изобрази 'ID:' 
			и вие трябва да въведете някаква стойност за променливата 'id'. След като го направите, тя ще се присвои от колоната 'ID' от таблицата.

               		                  sqlcom.Parameters.Add("@USERNAME", username);
              		                  sqlcom.Parameters.Add("@PASSWORD", password);
                		  sqlcom.Parameters.Add("@EMAIL", email);
             			  sqlcom.Parameters.Add("@Role_ID", role_id);

	
Същото можете да направите и при Update и Delete.

Пример:

операцията Update -  SqlCommand ucom = new SqlCommand("UPDATE [PROJECT].[dbo].[USERS]" + "SET PASSWORD='programming'" + "WHERE USERNAME=@USERNAME", sqlcon);
                                   ucom.Parameters.AddWithValue("@USERNAME", usr); - тук указвате, че ще обновите паролата, според зададен Username

операцията Delete -    SqlCommand dcom = new SqlCommand("DELETE " + "FROM [PROJECT].[dbo].[USERS]" + "WHERE ID=@ID", sqlcon);
                	   dcom.Parameters.Add("@ID", id); - тук указвате, че ще изтрие даден ред, по задедено неговото ID


8. След това, трябва да прочете данните и да ги изобразите на екрана. Това става с класа SqlDataReader.

Пример:

        class Program
     {

          public static void Insert()
        {	
            string id;
            Console.Write("\n\n\t\t ID:");
            id = Console.ReadLine();

            string username;
            Console.Write("\n\t\t Username:");
            username = Console.ReadLine();

            if (username == "")
            {
                Console.WriteLine("\n The username cannot be empty!");
            }

            else
                if (username.Length < 5)
                {
                    Console.WriteLine("\n The username is too short!");
                }

                else
                    if (username != "" && username.Length >= 5)
                    {
                        string password;
                        Console.Write("\n\t\t Password:");
                        password = Console.ReadLine();

                        if (password == "")
                        {

                            Console.WriteLine("\n The password cannot be empty!");
                        }

                        else
                            if (password.Length < 5)
                            {
                                Console.WriteLine("\n The password must be betwen 5 and 15 symbols!");
                            }

                            else
                                if (password != "" && password.Length >= 5 || password.Length <= 15)
                                {
                                    string email;
                                    Console.Write("\n\t\t Email:");
                                    email = Console.ReadLine();

                                    if (email == "")
                                    {
                                        Console.WriteLine("\n The email cannot be empty!");
                                    }

                                    else
                                        if (email != "")
                                        {
                                            int role_id;
                                            Console.Write("\n\t\t Role_ID:");
                                            role_id = int.Parse(Console.ReadLine());


                                  if (role_id == 1 || role_id == 2)
                                  {
                                       
                                   SqlConnection sqlcon = new SqlConnection("Server=името на сървъра; Database=името на базата; Integrated Security=true; Persist Security Info=false;");
                                   sqlcon.Open();

                                   
                                  SqlCommand sqlcom = new SqlCommand("INSERT INTO [PROJECT].[dbo].[USERS] (ID, USERNAME, PASSWORD, EMAIL, Role_ID)" + "VALUES(@ID, @USERNAME, @PASSWORD, @EMAIL, @Role_ID)", sqlcon);
                                  sqlcom.Parameters.Add("@ID", id);
                                  sqlcom.Parameters.Add("@USERNAME", username);
                                  sqlcom.Parameters.Add("@PASSWORD", password);
                                  sqlcom.Parameters.Add("@EMAIL", email);
                                  sqlcom.Parameters.Add("@Role_ID", role_id);


                                  SqlDataReader sqldr = sqlcom.ExecuteReader();

                                  while (sqldr.Read())
                                  {

                                    Console.WriteLine("ID:{0}\n Username:{1}\n Password:{2}\n Email:{3}\n, Role_ID:{4}", sqldr.GetSqlValue(0), sqldr.GetString(1), sqldr.GetSqlValue(2), sqldr.GetString(3), sqldr.GetSqlValue(4));

                                   }

9. След като извършите необходимите операции, трябва да затворите обекта, дефиниран от класа SqlDataReader. Това става чрез името на обекта.Close().

Пример:
 	
        class Program
       {

          public static void Insert()
        {

            string id;
            Console.Write("\n\n\t\t ID:");
            id = Console.ReadLine();

            string username;
            Console.Write("\n\t\t Username:");
            username = Console.ReadLine();

            if (username == "")
            {
                Console.WriteLine("\n The username cannot be empty!");
            }

            else
                if (username.Length < 5)
                {
                    Console.WriteLine("\n The username is too short!");
                }

                else
                    if (username != "" && username.Length >= 5)
                    {
                        string password;
                        Console.Write("\n\t\t Password:");
                        password = Console.ReadLine();

                        if (password == "")
                        {

                            Console.WriteLine("\n The password cannot be empty!");
                        }

                        else
                            if (password.Length < 5)
                            {
                                Console.WriteLine("\n The password must be betwen 5 and 15 symbols!");
                            }

                            else
                                if (password != "" && password.Length >= 5 || password.Length <= 15)
                                {
                                    string email;
                                    Console.Write("\n\t\t Email:");
                                    email = Console.ReadLine();

                                    if (email == "")
                                    {
                                        Console.WriteLine("\n The email cannot be empty!");
                                    }

                                    else
                                        if (email != "")
                                        {
                                            int role_id;
                                            Console.Write("\n\t\t Role_ID:");
                                            role_id = int.Parse(Console.ReadLine());


                                  if (role_id == 1 || role_id == 2)
                                  {
                                     
                                   SqlConnection sqlcon = new SqlConnection("Server=името на сървъра; Database=името на базата; Integrated Security=true; Persist Security Info=false;");
                                   sqlcon.Open();

                                   
                                  SqlCommand sqlcom = new SqlCommand("INSERT INTO [PROJECT].[dbo].[USERS] (ID, USERNAME, PASSWORD, EMAIL, Role_ID)" + "VALUES(@ID, @USERNAME, @PASSWORD, @EMAIL, @Role_ID)", sqlcon);
                                  sqlcom.Parameters.Add("@ID", id);
                                  sqlcom.Parameters.Add("@USERNAME", username);
                                  sqlcom.Parameters.Add("@PASSWORD", password);
                                  sqlcom.Parameters.Add("@EMAIL", email);
                                  sqlcom.Parameters.Add("@Role_ID", role_id);


                                  SqlDataReader sqldr = sqlcom.ExecuteReader();

                                  while (sqldr.Read())
                                  {

                                    Console.WriteLine("ID:{0}\n Username:{1}\n Password:{2}\n Email:{3}\n, Role_ID:{4}", sqldr.GetSqlValue(0), sqldr.GetString(1), sqldr.GetSqlValue(2), sqldr.GetString(3), sqldr.GetSqlValue(4));

                                   }
  

                                    sqldr.Close();

                                   }
   			Console.WriteLine("\n\t\t You inserted a new row in the table!");
		}
	     }
	}
         }
       
	След това, този външен метод Insert() просто се извиква в програмата. Същото нещо се прави и за Update  и  Delete. Надолу всичко се пише
	в главната програма.

10. За да може като се натисне даден клавиш, да се изпълнява дадена операция, използваме класа ConsoleKeyInfo.

Пример:

                     ConsoleKeyInfo sqlcki;
                     sqlcki = Console.ReadKey();

11. След това използваме оператора 'switch'.

Пример:

 switch (sqlcki.Key)
                                {

                                   case ConsoleKey.Tab:
		   Insert();

		   break;

		}

Този пример представя, че ако се натисне клавишът 'Tab', ще се изпълни методът Insert(). 

12.  За да проверим дали даден потребител вече се е регистрирал в базата данни или не е, трябва  да дефинираме променлива от тип string, 
     чрез която потребителят ще укаже дали е нов или не.

Пример:

            Console.WriteLine("\t\t\t Welcome to my database!");

            string reg;
            Console.Write("\n Enter 'Registered' or 'Unregistered': ");
            reg = Console.ReadLine();

           След като сме дефинирали променливата, задаваме условие, чрез което ще определим какво ще се случава ако потребителят не е 
           регистриран
          

Пример:

	 if (reg == "Unregistered")
                {

                Console.Write("\n ID:");
                id_reg = Console.ReadLine();

                string username_reg;
                Console.Write("\n Username:");
                username_reg = Console.ReadLine();

                string password_reg;
                Console.Write("\n Password:");
                password_reg = Console.ReadLine();

                string email_reg;
                Console.Write("\n Email:");
                email_reg = Console.ReadLine();

                int role_reg;
                Console.Write("\n Role_ID:");
                role_reg = int.Parse(Console.ReadLine());  - До тук казваме на програмата, че ако потребителят е нов, трябва да се отворят полета, в които
	       		                                   той да въведе id, username, password, email и role_id. Тези полета отново са променливи, които 
    				                   дефинираме по същия начин, както  променливата 'reg'.
                                                                               

	След това пишем следния код:

	 if (id_reg != "" && username_reg != "" && password_reg != "" && email_reg != "" && role_reg == 1 || role_reg == 2)
                    {

                        SqlConnection sqlcon = new SqlConnection("Server=името на сървъра; Database=името на базата; Integrated Security=true; Persist Security Info=false;");
                        sqlcon.Open();

                        SqlCommand sqlcom = new SqlCommand("INSERT INTO [PROJECT].[dbo].[USERS] (ID, USERNAME, PASSWORD, EMAIL, Role_ID)" + "VALUES(@ID, @USERNAME, @PASSWORD, @EMAIL, @Role_ID)", sqlcon);
                        sqlcom.Parameters.Add("@ID", id_reg);
                        sqlcom.Parameters.Add("@USERNAME", username_reg);
                        sqlcom.Parameters.Add("@PASSWORD", password_reg);
                        sqlcom.Parameters.Add("@EMAIL", email_reg);
                        sqlcom.Parameters.Add("@Role_ID", role_reg);


                        SqlDataReader sqldr = sqlcom.ExecuteReader();

                        while (sqldr.Read())
                        {
                            Console.WriteLine("ID:{0}\n Username:{1}\n Password:{2}\n Email:{3}\n, Role_ID:{4}", sqldr.GetSqlValue(0), sqldr.GetString(1), sqldr.GetSqlValue(2), sqldr.GetString(3), sqldr.GetSqlValue(4));
                        }

                        sqldr.Close();

                    } - с този код указваме на програмата, че ако потребителят е попълнил всички полета за регистрация, стойностите от тези полета трябва да
        	        да бъдат записани в таблицата т.е. да се изпълни операцията Insert(). 

                  Console.WriteLine("\n Your dates were inserted in the database!");
                  Console.WriteLine("\n Now close the program and start it again!");

                } - тук казваме на потребителя, че трябва да затвори програмата и да я стартира отново след като е въвел всичките си данни.
   
13. Сега да трябва да зададем какво да се случи ако потребителят вече е регистриран в базата данни. Това става със следния код:

              else
                    if (reg == "Registered")
                    {
                        string reg_username;
                        Console.Write("\n Username:");
                        reg_username = Console.ReadLine();

                        if (reg_username == "")
                        {
                            Console.WriteLine("\n The username cannot be empty!");
                        }

                        else
                            if (reg_username.Length < 5)
                            {
                                Console.WriteLine("\n The username is too short!");

                            } - следният код указва, че ако потребителят е вече регистриран в системата, ще трябва да се логне чрез username, като за username
		се прави и малка валидация. След като се направи валидацията и потребителят е попълнин правилно своето username, ще се 
		покаже полето за паролата:

              if (reg_username != "" && reg_username.Length >= 5)
                        {
                            string reg_password;
                            Console.Write("\n Password:");
                            reg_password = Console.ReadLine();

                            if (reg_password == "")
                            {
                                Console.WriteLine("\n The password cannot be empty!");
                            }

                            else
                                if (reg_password.Length < 5 || reg_password.Length > 15)
                                {
                                    Console.WriteLine("\n The password must be between 5 and 15 symbols!");

                                } - тук отново се прави валидаця, този път за паролата и след като потребителят е въвел username и password, трябва да 
		    да се покаже и полето, в което да укаже, дали е admin или user т.е. role_id:

                              else
                                    if (reg_password != "" && reg_password.Length >= 5 || reg_password.Length <= 15)
                                    {
                                        Console.WriteLine("\n Now choose admin or user:");
                                        Console.WriteLine("\n 1: user  2: admin");

                                        int reg_role;
                                        Console.Write("\n Role:");
                                        reg_role = int.Parse(Console.ReadLine());

		След това трябва да зададем условие какво да направи програмата ако потребителя е попълнил своите username, password и role_id:

                             if  (reg_role == 1)
                                        {
                                            Console.WriteLine("\n\n\t\t\t Welcome, {0}!", reg_username);
                                            System.Threading.Thread.Sleep(1000);
                                            Select();

                                        } - с този код указваме, че ако полетата username и password са попълнени правилно и role_id приема стойност 1, това означава, 
   		           че потребителят е обикновен user и ще се изпълни само методът Select() т.е. той ще може само да вижда базата данни, без
		           да може да я променя


		След това пишем следния код:

		  else
                                            if (reg_role == 2)
                                            {

                                                string admin_pass = "manunited";
                                                Console.Write("\n\n Please, enter your admin password:");
                                                admin_pass = Console.ReadLine();

                                                if (admin_pass == "")
                                                {
                                                    Console.WriteLine("\n\n\t\t Your admin password cannot be empty!");
                                                }

                                         else
                                           if (admin_pass != "manunited")
                                             {
                                                 Console.WriteLine("\n\n\t\t Your admin password is incorrect!");

                                             } - тук указваме, че ако  полетата username и password са попълнени правилно и role_id приема стойност 2, това означава,
			че потребителят е admin, и той ще може да променя базата данни. За да докаже обаче, че наистина е админ, 
			той ще трябва да въведе и парола(admin_pass), която в случая е 'manunited'. Само след като бъде въведена тази парола,
			потребителят ще може да види таблицата и да извърши необходимите операции. Следователно трябва да укажем
			какво да се изпълни ако тази администраторска парола е въведена:

	                    else
                                          if (admin_pass == "manunited")
                                       {
                                          Console.WriteLine("\n\n\t\t\t Welcome, {0}!", reg_username);
                                          System.Threading.Thread.Sleep(1000);
                                          Select();

                                         Console.WriteLine("\n\t\t\t\t Menu:");
                                         Console.WriteLine("\n Please choose one of the options: \n");
                                         Console.WriteLine("1. Insert - press 'Insert'! \n");
                                         Console.WriteLine("2. Update - press 'Tab'!\n");
                                         Console.WriteLine("3. Delete - press 'Delete'!");


                                     ConsoleKeyInfo sqlcki;
                                     sqlcki = Console.ReadKey(); - След като admin_pass е въведена, ще се покажат опциите на менюто за 3те операции и чрез
					   натискането на един от 3те указани бутона, ще се изпълни съответната операция. За целта
					   се използва класа ConsoleKeyInfo. След това трябва да използваме операторът 'switch', за да
					   зададем кой бутон, коя операция да изпълнява:



                                  switch (sqlcki.Key)
                                {

                                 case ConsoleKey.Tab:

                                       Console.WriteLine("\n\n Choose the username to update his password!");

                                      Update();

                                      break;


                                case ConsoleKey.Insert:

                                      Console.WriteLine("\n\n\t\t\t Enter your data:");

                                      Insert();

                                       break;


                               case ConsoleKey.Delete:

                                      Console.WriteLine("\n \n Choose which row to delete:");

                                      Delete();

                                     break;
             
                                     }
                              }
                          }
                       }
                    }
                
	


	                    

