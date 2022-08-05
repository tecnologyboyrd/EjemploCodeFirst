IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Products] (
    [ProductId] int NOT NULL IDENTITY,
    [name] nvarchar(50) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220805034553_Migration1', N'6.0.7');
GO

COMMIT;
GO

