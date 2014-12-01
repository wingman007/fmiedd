create table users
(
	id int primary key not null,
	username varchar(10) not null,
	password varchar(10) not null,
	email varchar(255) not null
)
create table roles
(
	id int primary key,
	username varchar(10) not null,
	password varchar(10)
)
insert into users
values(1,'dani','password','dani@')

insert into users
values(2,'Lilyana','kotence','lilinka_13@')

insert into roles
values(1,'admin','admin')

insert into roles
values(2,'member','member')