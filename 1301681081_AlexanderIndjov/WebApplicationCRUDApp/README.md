#Introduction
**The project is simple CRUD operation in Web Forms with MS SQL Server
 So first thing to do is to open a program like management studio for example and  create new database to use on the project, Example database
 #Example 
 create database[UserRoles]

use[UserRoles]

Create table Users
(
ID int primary key,
Username varchar(30) not null,
Password varchar(30) not null,
Email varchar(255) not null unique
)
Create table Roles
(
RoleID int primary key identity,
Roles varchar(30) not null,
IsAdmin bit
)
alter table Users
add RoleID int foreign key
 references Roles(RoleID)

 insert into Roles
 Values('Admin',1)
 insert into Roles
 Values('Member',0)
 insert into Users
 Values(2,'Sasho','20071994','Sashe944@abv.bg',1)
  insert into Users
 Values(1,'Alex','AlexPass','Alex94@abv.bg',2)**
 
  # Working and adding SQL Server to the project 
 First we open the project via Visual Studio, reommended 2013's version
 Second we go to the tab View and find the option called SQL Server Object Explorer, after that a menu pops up with all the servers that are imported in VS,
 so we add SQL Server by folowing the needed steps, Note: use Server Authentication for the task! 
 Third we make sure to change the DataSource for our GridView so it can show us the proper information for the task! Note : make sure to use the name of the server when it is asked and make sure to use SQL Server Authentication AGAIN!
 tehn select the required database for the task. Congrats now our GridView is ready to show the proper information needed! Finally to configure our connection string
 # Connection String
 First things first, how can we obtain the connection string ? Easy,
 first we go to our Web.Config file 
 second we search for the tag with name connectionStrings and in it we should find our connection string name
 third we coppy the name inside the brakets and we paste it on every page where we use the connection string to make connection with the servers's database
 finally we start the project and test it any problems
 Specia thnks to my mind! Enjoy the project :) **
