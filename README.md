fmiedd
======
Instructions for running the program!

	If you have installed SQL Server and SQL Managment Stuio follow the instructions bellow
Connecting to SQL Server
1.First we have to make the databasa
	-Open SQL Managment Studio and connect to the server
	-In the "Object Explorer"Note:
(if you don't see the "Object Explorer" press F8,also you can find it in the Menu( where "File" is) in View and you can see it on the first option)
	-Right click on "Databases"
	-Choose "New Database"
	-In the dialog window,field "Database name" enter "Users" and then click OK
	-The table is located in "Object Explorer"->"Databases"-> Users-This is the database we just created
	-Right click on Users
	-Choose "New query"
	-Blanck white window will open
	-Copy/Paste the test bellow

		--Start Copy
		create table [Roles]
		(
		[ID] int identity (1,1) not null,
		[Role] nvarchar(50) not null,
		PRIMARY KEY CLUSTERED ([Id] ASC)
		)

		Insert into Roles values ('admin')
		Insert into Roles values ('member')
		Insert into Roles values ('public')

		Create table [User]
		(
    		[Id] INT IDENTITY (1, 1) NOT NULL,
    		[Username] NVARCHAR (50) NOT NULL,
    		[Password] NVARCHAR (50) NOT NULL,
    		[Email]    NVARCHAR (50) NOT NULL,
		[Role_ID] int FOREIGN KEY REFERENCES Roles (ID) not null ,
    		PRIMARY KEY CLUSTERED ([Id] ASC)
		)
		Insert into [User] values('admin','admin','admin@gmail.com',1)
		Insert into [User] values('member','member','member@gmail.com',2)
		Insert into [User] values('public','public','public@gmail.com',3)
		--End Copy


	-Paste it in the Query we just opened
	-Right click in the query window
	-choose Execute
The database is done!

2.Connecting the database "Users" to the application
	-Open Visual studio and load the CRUD.sln file from the folder
	-Click on View (Where the Fille is) -> Other Windows ->Database Explorer
	-On the DataBase Explorer, select and right click Data Connection
	-Choose add connection
	-In the window that opened choose Microsoft SQL Server as Data sorce
	choose .Net Framework Data providerfor SQl Server, hit Ok button
	-Select the Server name (The name of the server where you createt the database Users)
	-If you have SQL serverAuthentication enter the username and the password
	-Select the the database name from the dropdown menu in the section "Connect to a database", Select or enter a database name
	-Press Test Connection
		-if the connection faild, check the server name and the authentication
	-Press Ok
	-On the new data connection, right click and choose modify connection
	-Press Advanced
	-In the Advanced properties just up tp the buttons ok and cancel you can see the connection string
	-Copy the text (It will look something like this: Data Source=Server Name;Initial Catalog=Users;Integrated Security=True)
	-Go to the Solution Explorer (you can find it in View)
	-Click on Data (expaned it), double click on DataConnection.cs
	-change this "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Data\\UserDataBase.mdf;Integrated Security=True";
	with the connection string you just copy
Note:it has to be surouded with " " and ; at the end.there will be errors when you try to run the program, on the underlined place add another \

the connection is done!

When you run the program you will need username and password
for administrator use: username:admin password:admin - this user can view, add, update and delete users
for member use : username: member password:member -this user can only view inserted user
for public use  username: public password:public Note: the public has no rights so the app will return incorect username and password

	If you don't have SQL Server and SQl Managment Studio you can run the program without doing any changes!

 

