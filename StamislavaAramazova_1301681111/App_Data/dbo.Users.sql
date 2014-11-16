CREATE TABLE [dbo].[Users] (
    [id]       INT        NOT NULL,
    [username] NCHAR (10) NOT NULL,
    [password] NCHAR (10) NOT NULL,
    [email]    NCHAR (20) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([id] ASC)
);

