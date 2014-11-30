create database[users]
use [users]
create table Users
(
ID int primary key identity(1,1),
username varchar(25) unique not null, 
pass varchar(20) not null,
full_name varchar(40),
email varchar(40)
)
create table Roles
(
ID int foreign key references Users unique,
role varchar(20)
)

alter table Roles
add constraint ch_roles check(role is null or role in ('admin','public','member'))

INSERT INTO Users 
VALUES ('admin','adminpass','admin adminov','admin@gmail.com');
Insert into Roles
values (1,'admin')

INSERT INTO Users 
VALUES ('galq','galqpass','Galq','galq@gmail.com');
Insert into Roles
values (2,'mamber')

INSERT INTO Users 
VALUES ('valq','valqpass','valq','valq@gmail.com');
Insert into Roles
values (3,'member')