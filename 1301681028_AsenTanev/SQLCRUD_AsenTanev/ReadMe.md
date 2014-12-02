1. Стартирайте SQL Server Management
2. Цъкнете върху New Query 
3. Ако имате създадена база данни "Users" използвайте нея чрез заявката "Use Users", а ако не създадена я създате чрез тази заявка: "Create database Users"
4. След като използвате вече и работите с базата данни Users, ще трябва да изпълните този код за да създадете таблицата на име fmi_users:

Create Table fmi_users
(id int primary key,
username varchar(15),
password varchar(20),
email varchar(25)
)

5. След това ще трябва да създадем таблицата Roles, с този код:

create table Roles
(
role_id int primary key not null,
role varchar(10) not null
)

6. Също трябва да инсертнем тези стойност с този код:

INSERT INTO Roles(role_id,role) VALUES (1,'admin')
INSERT INTO Roles(role_id,role) VALUES (2,'member')
INSERT INTO Roles(role_id,role) VALUES (3,'public')

7. Сега е нужно да добавим външният кей със референция към таблицата Roles с този код:

alter table fmi_users
add role_id int foreign key references roles

8. Също така е добре да добавим тези стойности в таблицата fmi_users:

INSERT INTO fmi_users(id,username,password,email,role_id) VALUES(1,'Admin','Admin@mail.net',1)
INSERT INTO fmi_users(id,username,password,email,role_id) VALUES(2,'MemberName','Member@mail.net',2)

9. SQL база данните и таблиците ни са готови сега ще преминем към отварянето на C# проекта. Отворете файлът с име "SQLCRUD_AsenTanev.sln" 

10. Сега е нужно да отворим снимката с име steps, тази снимка описва колко лесно се осъществява връзката.

step 1: Отваряме Server Explorer който се намира на табът View.

step 2: След като се появи прозорчето натискаме дясно копче и след това Add Connection.

step 3: За избор на Data Source е нужно да посочим Microsoft SQL Server (SqlClient). 
В SQL Server Management от дясно се намира табър Properties, от там копирате "Connection Name" 
в случая името на връзката, но не копирате всичко а до скобите.
След това го пействате в Server Name, настройвате си Log on to sever чрез windows authentication или SQL Server authentication.
От там ще ви се даде възможност за изберете име на база данни, в случая избираме Users, кликаме OK.

step 4: Накрая е нужно да копираме Connection stringа и да го поставим вместо текущия IVO/PC. И сме готови да стартираме програмата!

ЗА ДА ВЛЕЗНЕТЕ КАТО АДМИН Е НУЖЕН USERNAME: admin AND PASSWORD: adminpass, а като member USERNAME: стринг с повече от 8 букви или равни на 8 например MemberName,
и Password: задължително трябва да започва със 13013.