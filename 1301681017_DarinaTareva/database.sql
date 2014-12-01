use Project_Users

create table Project_Users
(
id int not null primary key,
username nchar(10) not null,
password nchar(10) not null,
email nchar(100) not null,
role_id int not null
)

Create table Role_id
(
id int not null foreign key references Project_Users,
role nchar(10) not null

)

insert into Project_Users
values ('1','Nevena','password1', 'veni@abv.bg','1')
insert into Project_Users
values ('2','Ani','password2', 'ani@abv.bg','2')
insert into Project_Users
values ('3','Mark','password3', 'mark@gmail.com','2')
insert into Project_Users
values ('4','Antoniya','password4', 'ant@abv.bg','2')
insert into Project_Users
values ('5','Zdravko','password5', 'zdravko@abv.bg','2')
insert into Project_Users
values ('6','Spas','password6', 'spas_d@abv.bg','2')
insert into Project_Users
values ('7','Yanko','password7', 'yanko@abv.bg','2')
insert into Project_Users
values ('8','Suzana','password8', 'suz@abv.bg','2')
insert into Project_Users
values ('9','Chris','password9', 'chris@gmail.com','2')
insert into Project_Users
values ('10','Georgi','password10', 'george@gmail.com','2')