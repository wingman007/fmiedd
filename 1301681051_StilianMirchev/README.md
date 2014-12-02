How to setup and use
===
SETUP!

1.Open the webCrud.sln .

2.Create a new database name Users.

3.Create a new query and add the following code : 

create table [user]
(id int primary key identity ,
username varchar(50) not null,
password varchar(50) not null,
email varchar(50) not null
);

create table Log_form(
User_Id int primary key identity,
log_uname varchar(50) not null,
log_pass varchar(50) not null,
user_role int 
);

Hit Execute.

Add this code next :

CREATE PROC spRegisterUser1 
@UserName NVARCHAR(100)
,@Password NVARCHAR(200)
,@UserRole int

AS
BEGIN
DECLARE @Count INT
DECLARE @ReturnCode INT

SELECT @Count = COUNT(log_uname)
FROM Log_form
WHERE log_uname = @UserName

IF @Count > 0
BEGIN
SET @ReturnCode = - 1
END
ELSE
BEGIN
SET @ReturnCode = 1

INSERT INTO Log_form
VALUES (
@UserName
,@Password
,@UserRole

)
END

SELECT @ReturnCode AS ReturnValue
END

Hit Execute.

Add this code last:
Create Procedure spAuthenticateUser
@UserName nvarchar(100),
@Password nvarchar(100)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(log_uname) from Log_form
 where [log_uname] = @UserName and [log_pass] = @Password
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End 

Hit Exectue.



4.Connect to the DB.


5.Copy the connection string located in the properties of the DB.


6.Paste the connection string in the Web.config file located at the bottom of the solution explorer.The connection string is located after the <system.web> tag.


7.After you have connected the DB and set up the conn string go to View.aspx. Open the Design tab and hit the Grid View arrow. 
There click on the choose data source option and click on the <New Data Source> tab. 
Select Database and click Ok. Select the datebase Users that you created and click next.
From the dropdown menu select "user" and click advanced.Chech the first option and click ok.Click next and then click the finish button.From the arror click on Enable editing and deleting.

8.Do the same for SimpleView.aspx without the advanced part.


9.Click on the Default.aspx and start the app.


HOW TO USE!

1.Register as a new user.

2.Log in.

3.Dependending on the fact if you registerd as a normal user or an admin you will get different priviliges.

Credit:

#References
  - [https://www.youtube.com/watch?v=AoRWKBbc6QI] [1]

[1]:https://www.youtube.com/watch?v=AoRWKBbc6QI


