create database [WebApplicationDB]
use [WebApplicationDB]
create Table Users
(
user_id smallint primary key,
username varchar(15) not null,
password varchar(15) not null,
email varchar(20) not null
)
create table Roles
(
role_id smallint not null foreign key references Users on delete cascade,
role varchar(max)
)
alter table Roles
add constraint role_check check(role is null or role in ('public','member','admin'))

insert into Users(user_id,username,password,email)
values (1,'Lilyana','Lilyanapass','lilinka_13@abv.bg')
insert into roles(role_id,role)
values (1,'admin')
insert into Users(user_id,username,password,email)
values (2,'Ivaylo','Halachev','Ivaylo@abv.bg')
insert into roles(role_id,role)
values (2,'member')
insert into Users(user_id,username,password,email)
values (3,'Nikoleta','Petrova','Niki_Petrova@abv.bg')
insert into roles(role_id,role)
values (3,'member')
insert into Users(user_id,username,password,email)
values (4,'Danica','Andreeva','Dani_123@abv.bg')
insert into roles(role_id,role)
values (4,'member')
insert into Users(user_id,username,password,email)
values (5,'Gergana','Petkova','Geri_876@abv.bg')
insert into roles(role_id,role)
values (5,'admin')