STARTING

EXECUTE THIS IN NEW QUERY:

create database [alexander]

use [alexander]

create table Users

(

ID int primary key,

Username varchar(20) not null,

password varchar(20),

Firstname varchar(20) not null,

Lastname varchar(20) not null,

Email varchar(20) not null,

)

create table roles

(

role_id int not null foreign key references Users on delete cascade,

role varchar(max)

)

alter table roles

add constraint role_check check(role is null or role in ('public','member','admin'))


insert into users(ID,Username,password,Firstname,Lastname,Email)

values (1, 'admin','alexanderpass','Alexander','Travlev','alexander@gmail.com')

insert into roles(role_id,role)

values (1,'admin')

insert into users(ID,Username,password,Firstname,Lastname,Email)

values (2, 'marioI','mario','Mario','Ivanov','mario@abv.bg')

insert into roles(role_id,role)

values (2,'member')


THEN CHANGE CONNECTIONG STRING IN CLASS-CONNECTION AND STARTUP LOGINFORM

