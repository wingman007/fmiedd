create database [Users]
use [Users]

create table users
(
id int primary key,
fname varchar(20) not null,
lname varchar(20) not null,
password varchar(20)
)

create table roles
(
role_id int not null foreign key references users on delete cascade,
role varchar(max)
)
alter table roles
add constraint role_check check(role is null or role in ('public','member','admin'))

insert into users(id,fname,lname,password)
values (1, 'admin','admin','admin')
insert into roles(role_id,role)
values (1,'admin')

insert into users(id,fname,lname,password)
values (2, 'admin2','admin','admin')
insert into roles(role_id,role)
values (2,'admin')

insert into users(id,fname,lname,password)
values (3, 'user','user','user')
insert into roles(role_id,role)
values (3,'member')

insert into users(id,fname,lname,password)
values (4, 'user2','user','user')
insert into roles(role_id,role)
values (4,'member')