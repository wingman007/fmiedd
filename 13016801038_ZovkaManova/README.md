This project is a CRUD with WinForms + MS SQL Server.
--------------------

Star the project
----------------

1) Attach the database to the MS SQL Server. (ProjectEED\ProjectEED\DataUsersDB.mdf)

Right mose click "Attach" in the MS SQL Server Management Studio -> "Add"

Note: Move the file accessable for the Server

The path to the SQL server should be relative. 
If this doesn't work change the connection string in all 4 repository files in the folder Repository (UserRepository etc.)

e.g.             
```
this.conn.ConnectionString = "Data Source=FMI-431-2\\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=False; User ID=sa; Password=sa";

another example:

@"Data Source=FMI-431-2\SQLEXPRESS;Initial Catalog=users;User ID=sa;Password=sa;Integrated Security=false";

```
the password and user name for login as admin:
username: zovka
password: zovkapass


The admin role can not execute tasks but can only assign them to the other users.

the password and user name for login as member:
username: mariana
password: marianapass


To log out close the application and launch it again.
