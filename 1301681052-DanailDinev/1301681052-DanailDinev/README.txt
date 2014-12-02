---------------------------------------------------------------
Simple console application for user management with AccessDB
---------------------------------------------------------------

Simple application which uses console interface to change user details from access database(oledb).

Features: login screen, user roles(admin, member, guest), add, edit, ban, delete users.

No need to configure anything! 

If you try to move your program or accessdb file, make sure after that you have changed the 'DataSourceURL' 
string with the new accessdb file path.

Some users form the table for login:
user: dan   / pass: dan  - admin
user: az    / pass: az   - member
user: ff    / pass: ff   - banned user
or leave empty for guest session

Warning! Some parts of the parts are hard coded(user roles, rows names and position), so be carefull when editing!

Happy coding!

Project by Danail Dinev 1301681052