Execute the query in order in management studio
First:
create database CRUD

Second:
use CRUD

Third:
create table crudProj
(
id int not null,
username varchar(30) not null,
password varchar(30) not null,
email varchar(30) not null
)

Fourth:
insert into crudProj(id,username,password,email)
values(10,'userOne','passOne','mail@mail.mail')
insert into crudProj(id,username,password,email)
values(12,'userTwo','passTwo','mail2@mail.mail')
insert into crudProj(id,username,password,email)
values(13,'userThree','passThree','mail3@mail.mail')

Then change open the project and change the connection string in Repository.cs to "Server=...1...;Database=CRUD;User Id=sa;
Password=sa;Integrated Security=false"

Where ...1... is local SQL server to get it open management studio connect to the server, then right click of the name of the server(1st thing in Object explorer) and copy name. Then paste it on ...1...

For username and password use admin/admin to log as administrator and have full rights. To log as user you can use any other combination  for username and password.