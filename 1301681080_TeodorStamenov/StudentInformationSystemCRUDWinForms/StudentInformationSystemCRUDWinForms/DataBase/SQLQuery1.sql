create table Students
(
	RegNo char(10),
	Fname varchar(50),
	Lname varchar(50),
	Phone char(10),
	Password char(50),
	Primary key (RegNo)
)

create table Roles
(
	[ID] int identity (1,1) not null,
	[Role] nvarchar(50) not null,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)

Insert into Roles values ('admin')
Insert into Roles values ('member')
Insert into Roles values ('public')

ALTER TABLE Students
ADD Role_Id integer

ALTER TABLE Students
ADD FOREIGN KEY (Role_Id) REFERENCES Roles(ID)