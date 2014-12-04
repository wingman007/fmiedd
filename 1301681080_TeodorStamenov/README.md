STUDENT INFORMATION SYSTEM CRUD PLUS LOGIN FORM
======================
HOW TO START?
-----------
> To start the project you need Visual Studio 2013 and SQL SERVER - Data base server installed!
>
> Set up the data base:
> To set it go to ...\StudentInformationSystemCRUDWinForms\DataBase and open SQLQuery.sql in your SQL Server Management Studio and Execute the file.
>
> Set up the connection string:
> Go to ...\StudentInformationSystemCRUDWinForms\DB_Access.cs open it with Visual Studio 2013 and search for 
SqlConnection. Edit ONLY the connectionString! In the end you need 
to have somthing like this: SqlConnection conn = new SqlConnection("Data Source=Admin-PC\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");
>Then Go to ...\StudentInformationSystemCRUDWinForms\Authentication.cs open it and search for SqlConnection. Copy the previous ConnetionString
and put it in the brackets. In the end you need 
to have somthing like this: SqlConnection conn = new SqlConnection("Data Source=Admin-PC\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");
>
> ### ENJOY
