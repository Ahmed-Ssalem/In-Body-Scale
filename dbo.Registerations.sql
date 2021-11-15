CREATE TABLE [dbo].[register] (
    [Id]       INT        NOT NULL DEFAULT 1,
    [username] NCHAR (50) NOT NULL,
    [email]    NCHAR (50) NOT NULL,
    [password] NCHAR (50) NOT NULL,
    [confirm]  NCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

