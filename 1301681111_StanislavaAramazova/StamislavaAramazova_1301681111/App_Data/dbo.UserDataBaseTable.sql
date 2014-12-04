CREATE TABLE [dbo].[UserDataBaseTable] (
    [ID]       INT        NOT NULL,
    [Username] NCHAR (15) NOT NULL,
    [Password] NCHAR (10) NOT NULL,
    [Email]    NCHAR (20) NOT NULL,
    CONSTRAINT [PK_UserDataBaseTable] PRIMARY KEY CLUSTERED ([ID] ASC)
);

