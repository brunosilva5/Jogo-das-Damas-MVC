CREATE TABLE [dbo].[Users] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [UserName]   VARCHAR (100) NOT NULL,
    [Name]       VARCHAR (100) NOT NULL,
    [Password]   VARCHAR (100) NOT NULL,
    [Photo]      VARCHAR (255) NOT NULL,
    [Email]      VARCHAR (255) NOT NULL,
    [Country]    VARCHAR (50)  NOT NULL,
    [NumGames]   VARCHAR (5)   NOT NULL,
    [NumWins]    VARCHAR (5)   NOT NULL,
    [NumDefeats] VARCHAR (5)   NOT NULL,
    [NumLeave]   VARCHAR (5)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

