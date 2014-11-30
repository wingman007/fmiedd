1301681017 Darina Tareva, task1 by Stoyan Cheresharov

What is? - My project is on ASP.NET, login page and preview form with admin authentication.
How to use? - For you to connect to the database you need to create database with table Project_Users - id,username,password,email,role_id
for id and role_id int others nvarchar(100), secound table Role - role_id,role - role_id int not null foreign key references Project_Users,
role nchar(10).
Next step is to connect to the database: change connection strings in the code with your current connection string.
Admin vs Not Admin - when you log in with admin you can make changes and insert new users/or delete existing but if logged user
is not admin you can only see user records in the database.
