--1. 
create table [Roles]
(
[ID] int identity (1,1) not null,
[Role] nvarchar(50) not null,
PRIMARY KEY CLUSTERED ([Id] ASC)
)

--2.
Insert into Roles values ('admin')
Insert into Roles values ('member')
Insert into Roles values ('public')

--3.
Create table [User]
(
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
	[Role_ID] int FOREIGN KEY REFERENCES Roles (ID) not null ,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)