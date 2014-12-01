create database [users-:)]
use [users-:)]
create table Table_1
(
ID int primary key,
NAME varchar(20) not null,
ADDRESS varchar(20) not null,
PASSWORD varchar(20) not null
)
create table Roles
(
role_id int not null foreign key references Table_1 on delete cascade unique,
role varchar(max)
)
insert into Table_1
values(1, 'Lili', 'undead66@abv.bg', '1234')
insert into roles(role_id,role)
values (1,'admin')
insert into Table_1
values(2, 'Dani', 'undead66@abv.bg', 'ninja turtle')
insert into roles(role_id,role)
values (2,'member')
insert into Table_1
values(3, 'Ivan', 'undead66@abv.bg', '123456')
insert into roles(role_id,role)
values (3,'member')

