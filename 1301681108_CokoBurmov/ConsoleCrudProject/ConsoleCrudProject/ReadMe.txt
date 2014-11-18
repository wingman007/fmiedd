Execute the query in management studio
First:
create database CRUD

Second:
create table crudProj
(
id int not null,
username varchar(30) not null,
password varchar(30) not null,
email varchar(30) not null
)

Third:
insert into crudProj(id,username,password,email)
values(10,'userOne','passOne','mail@mail.mail')
insert into crudProj(id,username,password,email)
values(12,'userTwo','passTwo','mail2@mail.mail')
insert into crudProj(id,username,password,email)
values(13,'userThree','passThree','mail3@mail.mail')