interface Simple Users Control Kit - iSUCK
======

Hello, mah man! This is just a sweet little simple application for control users database with elementary crud operations. 
The application includes : 
 1. Smart login form which switches between forms depends on user role logged in.
 2. Administration panel with access to all CRUD actions, including export all records in .txt file.
 3. User panel with access only to retrieve and export action.
 4. Register form which register new users with default User role.

Bugs which we know : 
 1. Administrator can't edit user roles. It only can be done manual by database. 
 2. Switches between the tabs & forms sometimes doesn't work properly. 
 
Requirements for application : 
 1. Visual Studio Express or equivalent.
 2. MSSQL Database server. (SQLEXPRESS or MSSQLDATABASES)
 3. Notepad or equivalent text editor.
 
How to install it : 
 1. Open StudentsDB.sln in Visual Studio
 2. Find file App.Config and edit the both connection strings for connecting application to your local server. 
 Where : 
    - "localhost\MSSQLDATABASES" is the server name and reference
    - "User ID= sa" is database user you usually use
    - "Password= sa" is the database password you usually use
    - SAVE!
  3. In folder "toInsert" exist SQL Query file, called "zaQvkataDLG.sql" , which you have to import into your database server.
  
After doing thissteps, feel free to use the application!
Congratulations!
