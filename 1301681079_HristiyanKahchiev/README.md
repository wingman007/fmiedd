1.Стартирайте SQL Server Management

2.Цъкнете върху New Query

3.Ако имате създадена база данни "Users" използвайте нея чрез заявката "Use Users", а ако не създадена я създате чрез тази заявка: "Create database Users"

4.След като използвате вече и работите с базата данни Users, ще трябва да изпълните този код за да създадете таблицата на име fmi_users:
Create Table fmi_users (id int primary key, username varchar(15), password varchar(20), email varchar(25) )

5.След това ще трябва да създадем таблицата Role, с този код:
create table Role ( role_id int primary key not null, role varchar(10) not null )

6.Също трябва да инсертнем тези стойност с този код:
INSERT INTO Role(role_id,role) VALUES (1,'member') INSERT INTO Role(role_id,role) VALUES (2,'public') INSERT INTO Role(role_id,role) VALUES (3,'admin')

7.Сега е нужно да добавим външният кей със референция към таблицата Role с този код:
alter table fmi_users add role_id int foreign key references roles

8.SQL база данните и таблиците ни са готови сега ще преминем към отварянето на C# проекта. Отворете файлът с име "ConsoleApplication.sln"

9. Отваряме Server Explorer който се намира на табът View.

10. След като се появи прозорчето натискаме дясно копче и след това Add Connection.

11. За избор на Data Source е нужно да посочим Microsoft SQL Server (SqlClient). В SQL Server Management от дясно се намира табът Properties, от там копирате "Connection Name" в случая името на връзката, но не копирате всичко а до скобите. След това го пействате в Server Name, настройвате си Log on to sever чрез windows authentication или SQL Server authentication. От там ще ви се даде възможност за изберете име на база данни, в случая избираме Users, кликаме OK.

12. Накрая е нужно да копираме Connection string-a и да го поставим вместо текущия. И сме готови да стартираме програмата!

Важно!!!Когато поиска парола за Admin, въвеждаме следната: "adminpassword".