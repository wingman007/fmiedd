SQL and Console (Visual studio 2013)
За да стартирате и тествате проекта трябва  да изпълните следните стъпки.
=====

Стартиране на проекта

1.Стартирайте Microsoft Visual Studio и после проект Stelka_Console
2.В sql Server Management Studio създайте база дани Users и след това  в нея таблици users  и Roles

create table users
(
id int identity(1,1) primary key,
username nchar(10),
lname nchar(10),
password nchar(10),
email nchar(10),
role_id int not null,
)

create table Roles
(
id int not null,
role varchar(20) not null,
)

3.Свържете базата данни с Visual Studioto и променете в Program.cs :
new OleDbConnection("Provider=SQLNCLI11;Data Source=STELKA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Users");
 с вашият Provider на базата ви
 

