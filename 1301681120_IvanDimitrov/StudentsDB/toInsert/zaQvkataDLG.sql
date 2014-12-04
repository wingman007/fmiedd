CREATE DATABASE STUDENTS;

CREATE TABLE [STUDENTS].[dbo].[Users]
(
id INT NOT NULL AUTO_INCREMENT,
username VARCHAR(60) NOT NULL,
password VARCHAR(60) NOT NULL,
email VARCHAR(60) NOT NULL,
role_id(int, null),
PRIMARY KEY ( id )
);

CREATE TABLE [STUDENTS].[dbo].[Roles]
(
id INT NOT NULL,
role VARCHAR (16) NOT NULL,
PRIMARY KEY (id)
);

INSERT INTO [STUDENTS].[dbo].[Users]
VALUES (
'admin',
'admin',
'admin@iSUCK.com',
3
);

INSERT INTO [STUDENTS].[dbo].[Roles]
VALUES (1,'guest'), (2,'member'), (3,'admin');

