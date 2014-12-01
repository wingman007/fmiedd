Simple CRUD Application
===================

Introduction
---------------
This is simple application using the Console and SQL Server. 
You have a table with fields id, username, password and email.
Automatically exist in the table are 10 entries, which you can see at startup.

What programs use to work CRUD Application?
----------------------------------------------------------
SQL Server 2014 Management for create database with fields and records, and also Visual Studio.

How to run the application?
---------------------------------
Before you start the application, you must perform the following steps:

1. Go to UserRepository.cs and then change SqlConnection with your Connection string. 
For this purpose, go to Server Explorer, click on Data Connection, then select your database. 
On the right will appear window Properties. Click on Connection string, copy your connection 
and then put it on return new SqlConnection(" "). Between brackets put your connection string.
2. Ok, after completed first step, now you can start application with Visual Studio.
3. Window appears which requires you to enter username and password for login.
Your username must be "maria", and your password must be "mariapass". 
Otherwise, you can't move forward and the program will display that you have entered wrong 
username or password.
4. Once you have logged on with the correct username and password, the program will welcomed 
and in front of you a menu will appear with four commands  from which to choose.

4.1 If you want to read all the contacts, you must be press the R or r (no matter big or small "r") 
and the program will show you all the contacts in the database.
4.2 If you want to add a contact, you must be press the A or a (no matter big or small "a", again).
4.3 If you want to update a contact, you must be press the U or u (yes, this way again - no matter 
big or small ''u'' you choose to use)
4.4 And finally, if you want to delete a contact, you must be press the D or d (no matter big or small 
letter ''d'').

5. That's all. Have fun!

Recommends
----------------
If you wonder, how to create a login form, answer is here:
http://stackoverflow.com/questions/15451110/creating-an-authentication-console-application-using-gettickcount-function

http://www.youtube.com/user/coolcsn/videos

http://mind42.com/public/c693e3bf-60fe-48de-88b9-229e50b82d81