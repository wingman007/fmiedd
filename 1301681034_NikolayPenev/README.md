CRUD + MSSQL Server Project
======
Start the project and follow the steps:
------
This is my project which contains simple login and users .Thå project has been created with educational
purposes to show CRUD operations:(Create, Retrieve, Update,Delete).
I use MSSQL database to keep my data.
You can load the project on Visual Studio by pressing F5.

1) Start MSSQL Server Management Studio and create new database

2) Attach the database to the MS SQL Server by changing the connection string in all 4 repository files:

For exaple:

this.conn.ConnectionString = "Data Source=FMI-431-2\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=False; User ID=sa; Password=sa";

another example:

@"Data Source=FMI-431-2\SQLEXPRESS;Initial Catalog=users;User ID=sa;Password=sa;Integrated Security=false";


Note: Connection with the database and main CRUD operations were performed with OleDbConnection

3)Òhe password and user name for login:
username: user1 
password: user1

To log out close the application.