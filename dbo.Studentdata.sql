CREATE TABLE [dbo].[Studentdata] (
    [libraryid]      INT           NOT NULL,
    [studentname]    NVARCHAR (50) NULL,
    [registernumber] NVARCHAR (50) NULL,
    [contactnumber]  NVARCHAR (50) NULL,
    [noofbooks]      INT           NULL,
    PRIMARY KEY CLUSTERED ([libraryid] ASC)
);

