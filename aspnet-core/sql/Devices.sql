IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Devices] (
    [Id] uniqueidentifier NOT NULL,
    [CreationTime] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Type] int NOT NULL,
    [Status] int NOT NULL,
    CONSTRAINT [PK_Devices] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220320055220_Create_Tbl_Devices', N'3.1.23');

GO

CREATE TABLE [DeviceDetails] (
    [Id] uniqueidentifier NOT NULL,
    [CreationTime] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [DeviceId] uniqueidentifier NOT NULL,
    [Temperature] real NOT NULL,
    [Usage] real NOT NULL,
    CONSTRAINT [PK_DeviceDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DeviceDetails_Devices_DeviceId] FOREIGN KEY ([DeviceId]) REFERENCES [Devices] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_DeviceDetails_DeviceId] ON [DeviceDetails] ([DeviceId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220320055236_Create_Tbl_DeviceDetails', N'3.1.23');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'IsDeleted', N'Name', N'Status', N'Type') AND [object_id] = OBJECT_ID(N'[Devices]'))
    SET IDENTITY_INSERT [Devices] ON;
INSERT INTO [Devices] ([Id], [CreationTime], [IsDeleted], [Name], [Status], [Type])
VALUES ('7c00b09f-4562-4e2f-b95d-edd6e2240b96', '2022-03-17T08:31:00.0000000', CAST(0 AS bit), N'Work Smartphone', 0, 0),
('98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', '2022-03-17T10:23:00.0000000', CAST(0 AS bit), N'Son Ipad', 0, 1),
('0e05ba9d-a84f-48da-bd1d-19eaabfe1590', '2022-03-18T09:04:00.0000000', CAST(0 AS bit), N'Home Laptop', 0, 3),
('7fa37ac2-9edf-469f-8d2a-535aab49b00e', '2022-03-19T17:38:00.0000000', CAST(0 AS bit), N'Hall Television', 0, 6),
('b2780a57-cce2-4244-9c28-5cee4c04f6b7', '2022-03-19T11:38:00.0000000', CAST(0 AS bit), N'Work Server', 0, 2),
('edd25796-460b-4da4-8340-4a283024d506', '2022-03-21T11:38:00.0000000', CAST(0 AS bit), N'Bedroom TV', 0, 6),
('9bea121f-ae8e-4db3-b433-419596e573eb', '2022-03-22T15:38:00.0000000', CAST(0 AS bit), N'Mom Smartphone', 0, 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'IsDeleted', N'Name', N'Status', N'Type') AND [object_id] = OBJECT_ID(N'[Devices]'))
    SET IDENTITY_INSERT [Devices] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220320055539_Seed_Tbl_Devices', N'3.1.23');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'DeviceId', N'IsDeleted', N'Temperature', N'Usage') AND [object_id] = OBJECT_ID(N'[DeviceDetails]'))
    SET IDENTITY_INSERT [DeviceDetails] ON;
INSERT INTO [DeviceDetails] ([Id], [CreationTime], [DeviceId], [IsDeleted], [Temperature], [Usage])
VALUES ('a6114d42-3a47-4885-9191-60a1ca6d2d33', '2022-03-23T08:30:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(30.458 AS real), CAST(5437547 AS real)),
('ee964760-1c37-47a2-814b-431b775eef4a', '2022-03-23T08:30:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(30.458 AS real), CAST(3463443 AS real)),
('f6c00033-0301-42f1-896e-532ca2585873', '2022-03-23T08:50:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(30.358 AS real), CAST(23523 AS real)),
('134c9061-afa3-4fa8-97e6-6a5d876000b0', '2022-03-23T08:40:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(33.458 AS real), CAST(235235 AS real)),
('d123c91e-36ff-463f-a33d-7948f5549439', '2022-03-23T08:30:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(30.458 AS real), CAST(451552 AS real)),
('433b8da2-7aee-4fc6-a580-7da212c0f58d', '2022-03-23T08:50:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(30.748 AS real), CAST(32532524 AS real)),
('f1916e35-0497-4c32-95f4-64bd41a9f6fb', '2022-03-23T08:40:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(30.658 AS real), CAST(2352352 AS real)),
('fb898af6-b59c-42b7-a861-220ec1b683a0', '2022-03-23T08:30:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(29.458 AS real), CAST(451552 AS real)),
('93dee4b7-172a-4016-9e33-709b2af32153', '2022-03-23T08:50:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(30.458 AS real), CAST(2652355 AS real)),
('9ffb6f9f-9b8c-4e4b-aeda-4653b8b4df53', '2022-03-23T08:40:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(32.458 AS real), CAST(321532 AS real)),
('65cc08bd-7fe3-4067-b659-7de85747571c', '2022-03-23T08:40:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(32.38 AS real), CAST(7363445 AS real)),
('4eaeaf69-0157-4252-b980-1440fb347068', '2022-03-23T08:50:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(30.458 AS real), CAST(43633 AS real)),
('4ec35344-5deb-4393-9403-38bb4e751c64', '2022-03-23T08:40:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(28.458 AS real), CAST(145125 AS real)),
('36afe48d-679e-4044-8035-36a33216f031', '2022-03-23T08:30:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(31.458 AS real), CAST(262623 AS real)),
('d33b0f4d-6df4-473d-a2e1-0f290bd0a80c', '2022-03-23T08:50:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(35.458 AS real), CAST(6345532 AS real)),
('08f6848c-27a2-41a9-a587-890d7512acb9', '2022-03-23T08:40:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(34.5658 AS real), CAST(52346248 AS real)),
('38896a30-53dd-4936-8ffd-1347730867ae', '2022-03-23T08:30:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(29.4458 AS real), CAST(236525 AS real)),
('c8975a67-e770-4a3a-bf35-0c205e99ba2d', '2022-03-23T08:50:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(32.5458 AS real), CAST(7564754 AS real)),
('d777861f-92f3-4688-b389-ec6ed33dd86b', '2022-03-23T08:40:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(28.458 AS real), CAST(5423818 AS real)),
('36cb705c-acf6-438f-9f69-324a13a0e56a', '2022-03-23T08:30:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(31.458 AS real), CAST(367357 AS real)),
('eeff1c90-d32e-4303-8744-d139c219666c', '2022-03-23T08:50:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(31.98 AS real), CAST(23523524 AS real));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'DeviceId', N'IsDeleted', N'Temperature', N'Usage') AND [object_id] = OBJECT_ID(N'[DeviceDetails]'))
    SET IDENTITY_INSERT [DeviceDetails] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220320061249_Seed_Tbl_DeviceDetails', N'3.1.23');

GO

