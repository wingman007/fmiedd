create database[users]
create table Users
(
ID int primary key identity(1,1),
usernanme varchar(25) unique not null, 
pass varchar(20) not null,
full_name varchar(40),
email varchar(40)
)