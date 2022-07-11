
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Employee] (
    [EmpID] int NOT NULL IDENTITY,
    [EmpLastName] nvarchar(max) NULL,
    [EmpFirstName] nvarchar(max) NULL,
    [EmpOrganization] nvarchar(max) NULL,
    [EmpCity] nvarchar(max) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([EmpID])
);

GO

CREATE TABLE [Persons] (
    [Id] int NOT NULL IDENTITY,
    [LastName] nvarchar(max) NULL,
    [FirstName] nvarchar(max) NULL,
    [Age] int NULL,
    [City] nvarchar(max) NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220523212025_initialmigration', N'3.1.7');

GO


