CREATE DATABASE PROJECT

USE PROJECT


CREATE TABLE USERS
(

	ID INT PRIMARY KEY,
	USERNAME VARCHAR(50) NOT NULL,
	PASSWORD VARCHAR(30) NOT NULL,
	EMAIL VARCHAR(30) NOT NULL

	)


	ALTER TABLE USERS
	ADD Role_ID INT


	CREATE TABLE ROLE
	(

		ID INT FOREIGN KEY REFERENCES USERS NOT NULL,
		Role VARCHAR(10) NOT NULL

		)


