CREATE TABLE [dbo].[Department]
(
	[DepartmentId] INT IDENTITY(1,1)  NOT NULL,
	[Name] VarCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ( [DepartmentId] ASC)
);
