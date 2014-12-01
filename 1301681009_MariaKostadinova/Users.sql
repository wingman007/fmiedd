create database DataBaseUsers
create table Users
(
id int primary key identity,
Username varchar(30) not null,
pass varchar(30) not null,
Email varchar(30) not null
)

INSERT INTO Users (Username, pass,Email) 
VALUES ('maria','mariapass','maria@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('reni','renipass','reni@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('ani','anipass','ani@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('geri','geripass','geri@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('stoyan','stoyanpass','stoyan@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('ivo','ivopass','ivo@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('georgi','georgipass','georgi@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('yordan','yordanpass','yordan@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('valeri','valeripass','valeri@abv.bg')

INSERT INTO Users (Username, pass,Email) 
VALUES ('nikolai','nikolaipass','nikolai@abv.bg')