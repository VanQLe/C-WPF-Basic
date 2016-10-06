CREATE TABLE [dbo].[Employee] (
    [EmployeeId]   INT          IDENTITY (1, 1) NOT NULL,
    [DepartmentId] INT          NOT NULL,
    [FirstName]    VARCHAR (20) NOT NULL,
    [LastName]     VARCHAR (20) NOT NULL,
    [Email]        VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [FK_Employee_Department] FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department] ([DepartmentId])
);