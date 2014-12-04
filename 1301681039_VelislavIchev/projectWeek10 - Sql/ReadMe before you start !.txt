Step 1: Open SQL Management Studio

create database [yourDatabaseName]
use yourDatabaseName

create table roles
(
   role_id int primary key not null,  
   role varchar(10)
)
create table users
(
id int primary key not null,
username varchar(10),
password varchar(10),
email varchar(20),
role_id int foreign key references roles not null
)
insert into roles
values(1,'admin')
insert into roles
values(2,'member')

insert into users
values(1,'admin','admin','admin@mail.com','1')
values(2,'name','name','name@mail.com','2')


Save!


Step 2: Now you have the DB. Open the project with 
Visual Studio -> View -> Server Explorer
, find your newly created database and connect. 
Then right click to the database click "properties" and copy the path of "connection string".

Step 3: Now you copied the connection string of your database. 
On the project, find Form1.cs and paste the connection string in "SqlConnection cn = new SqlConnection(@"[PUT IT HERE]"); 
Then find folder "Repo", paste the connection string in "this.cn.ConnectionString =(@"PUT IT HERE");

Step 4: And we are ready to open the application. 
When the application runs a login form will appear.
Type username:admin, password:admin.

You are done! Congratulations :)
