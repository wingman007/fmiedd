create database SpaceInvaderDB

create table Ranks(
	id varchar(10) primary key,
	title varchar(50) not null
)

insert into Ranks(id, title)
values('ad', 'Administrator') --For administrator

insert into Ranks(id, title)
values('ur', 'User') --For user

create table Users(
	id int identity(1,1) primary key,
	username varchar(50) unique not null,
	password varchar(50) not null,
	maxscore int default 0,
	rankid varchar(10) foreign key references Ranks(id)
)

insert into Users(username, password, maxscore, rankid)
values('admin', 'admin', 1000, 'ad') --Add admin

insert into Users(username, password, rankid)
values('rusakov', '123', 'ur') --Add user