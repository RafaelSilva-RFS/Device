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
('9bea121f-ae8e-4db3-b433-419596e573eb', '2022-03-22T15:38:00.0000000', CAST(0 AS bit), N'Mom Smartphone', 0, 0),
('5b9eda9d-d878-4b6d-b041-11e725bcccd4', '2022-03-19T11:38:00.0000000', CAST(0 AS bit), N'Work Hall Desktop', 1, 2),
('cde3b44e-9603-4fc4-89b4-a027c3aab5eb', '2022-03-21T11:38:00.0000000', CAST(0 AS bit), N'Work Hall TV', 0, 6),
('8f458b6f-40d7-48ac-9277-6727c45cfd22', '2022-03-22T15:38:00.0000000', CAST(0 AS bit), N'Work Smartphone', 0, 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'IsDeleted', N'Name', N'Status', N'Type') AND [object_id] = OBJECT_ID(N'[Devices]'))
    SET IDENTITY_INSERT [Devices] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220323023259_Seed_Tbl_Devices', N'3.1.23');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'DeviceId', N'IsDeleted', N'Temperature', N'Usage') AND [object_id] = OBJECT_ID(N'[DeviceDetails]'))
    SET IDENTITY_INSERT [DeviceDetails] ON;
INSERT INTO [DeviceDetails] ([Id], [CreationTime], [DeviceId], [IsDeleted], [Temperature], [Usage])
VALUES ('39c77279-fa83-493d-8581-e1771c7d7c1e', '2022-03-23T08:30:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(30.458 AS real), CAST(5437547 AS real)),
('f27deca6-efc1-49dc-85e6-48ecac1dcd82', '2022-03-23T08:30:00.0000000', '8f458b6f-40d7-48ac-9277-6727c45cfd22', CAST(0 AS bit), CAST(30.458 AS real), CAST(3463443 AS real)),
('8eb6a5be-86f6-4760-bf2e-b1e2ee3ac50b', '2022-03-23T08:50:00.0000000', 'cde3b44e-9603-4fc4-89b4-a027c3aab5eb', CAST(0 AS bit), CAST(31.98 AS real), CAST(23523524 AS real)),
('14b782bc-ce4f-4600-b75d-fce170dc2333', '2022-03-23T08:40:00.0000000', 'cde3b44e-9603-4fc4-89b4-a027c3aab5eb', CAST(0 AS bit), CAST(32.458 AS real), CAST(321532 AS real)),
('69b50dc5-4fa5-4056-8280-e0c615988df3', '2022-03-23T08:30:00.0000000', 'cde3b44e-9603-4fc4-89b4-a027c3aab5eb', CAST(0 AS bit), CAST(30.458 AS real), CAST(3463443 AS real)),
('993ae2c5-5495-4abe-98ec-12c6ecc9bbc1', '2022-03-23T08:50:00.0000000', '5b9eda9d-d878-4b6d-b041-11e725bcccd4', CAST(0 AS bit), CAST(31.98 AS real), CAST(23523524 AS real)),
('ee482c35-de11-4030-9515-323500db08de', '2022-03-23T08:40:00.0000000', '5b9eda9d-d878-4b6d-b041-11e725bcccd4', CAST(0 AS bit), CAST(32.458 AS real), CAST(321532 AS real)),
('f5aa9b1a-370f-4a80-9a22-8ebe49722258', '2022-03-23T08:30:00.0000000', '5b9eda9d-d878-4b6d-b041-11e725bcccd4', CAST(0 AS bit), CAST(30.458 AS real), CAST(3463443 AS real)),
('85ae8097-a6bb-4933-9adb-2114f11c6c29', '2022-03-23T08:50:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(31.98 AS real), CAST(23523524 AS real)),
('07865b3b-5559-4246-937f-46661f694361', '2022-03-23T08:40:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(32.458 AS real), CAST(321532 AS real)),
('620fb4d1-bb9e-479a-8583-655aefc13265', '2022-03-23T08:30:00.0000000', '9bea121f-ae8e-4db3-b433-419596e573eb', CAST(0 AS bit), CAST(30.458 AS real), CAST(3463443 AS real)),
('21ad706c-08bb-406d-bb7f-33890b908462', '2022-03-23T08:50:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(30.358 AS real), CAST(23523 AS real)),
('6793f594-aeff-4e9d-8b34-05968f732de7', '2022-03-23T08:40:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(33.458 AS real), CAST(235235 AS real)),
('b2d11652-c5e5-4093-93e6-ff8ed032c95f', '2022-03-23T08:30:00.0000000', 'edd25796-460b-4da4-8340-4a283024d506', CAST(0 AS bit), CAST(30.458 AS real), CAST(451552 AS real)),
('4f80e15a-b2af-4f86-b403-000218729525', '2022-03-23T08:50:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(30.748 AS real), CAST(32532524 AS real)),
('cf9f402f-2ba1-4080-a674-14ad0eea9824', '2022-03-23T08:40:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(30.658 AS real), CAST(2352352 AS real)),
('5e600eb4-597b-40a4-a5f6-6b44b90b6ef2', '2022-03-23T08:30:00.0000000', 'b2780a57-cce2-4244-9c28-5cee4c04f6b7', CAST(0 AS bit), CAST(29.458 AS real), CAST(451552 AS real)),
('40539503-7919-4f68-892a-e010918df244', '2022-03-23T08:50:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(30.458 AS real), CAST(2652355 AS real)),
('18029775-3e1c-4d5f-8f09-1b10cf7eb6ed', '2022-03-23T08:40:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(32.38 AS real), CAST(7363445 AS real)),
('c9f95416-8cd0-4e0c-a73f-de52c9be2d89', '2022-03-23T08:30:00.0000000', '7fa37ac2-9edf-469f-8d2a-535aab49b00e', CAST(0 AS bit), CAST(31.458 AS real), CAST(367357 AS real)),
('37d22d4d-23c0-41ca-91a5-072a70da5d83', '2022-03-23T08:50:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(30.458 AS real), CAST(43633 AS real)),
('b22769e6-efb1-4502-8d1e-6568db4dbd1f', '2022-03-23T08:40:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(28.458 AS real), CAST(145125 AS real)),
('d4419940-6f1a-48fd-9499-79594f20cb9a', '2022-03-23T08:30:00.0000000', '0e05ba9d-a84f-48da-bd1d-19eaabfe1590', CAST(0 AS bit), CAST(31.458 AS real), CAST(262623 AS real)),
('fa73f6c9-fe68-4e18-bf8b-c17ad8fa9373', '2022-03-23T08:50:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(35.458 AS real), CAST(6345532 AS real)),
('99ac592a-5123-4a63-94a1-cd161153d79e', '2022-03-23T08:40:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(34.5658 AS real), CAST(52346248 AS real)),
('9f2d9e79-c201-428e-bb50-ec9afe7bfa25', '2022-03-23T08:30:00.0000000', '98ec6ea5-d591-47f3-9f36-c1c9f2a3316c', CAST(0 AS bit), CAST(29.4458 AS real), CAST(236525 AS real)),
('15096be5-4434-4622-bcc7-79ac960be0c9', '2022-03-23T08:50:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(32.5458 AS real), CAST(7564754 AS real)),
('f51b1e84-71af-4987-b649-29d35cc8ac7b', '2022-03-23T08:40:00.0000000', '7c00b09f-4562-4e2f-b95d-edd6e2240b96', CAST(0 AS bit), CAST(28.458 AS real), CAST(5423818 AS real)),
('cde4793b-6af4-4aad-91b6-3eae2bf347c2', '2022-03-23T08:40:00.0000000', '8f458b6f-40d7-48ac-9277-6727c45cfd22', CAST(0 AS bit), CAST(32.458 AS real), CAST(321532 AS real)),
('d574f9d8-47ae-4e6b-8d2d-355e9cf63016', '2022-03-23T08:50:00.0000000', '8f458b6f-40d7-48ac-9277-6727c45cfd22', CAST(0 AS bit), CAST(31.98 AS real), CAST(23523524 AS real));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreationTime', N'DeviceId', N'IsDeleted', N'Temperature', N'Usage') AND [object_id] = OBJECT_ID(N'[DeviceDetails]'))
    SET IDENTITY_INSERT [DeviceDetails] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220323023343_Seed_Tbl_DeviceDetails', N'3.1.23');

GO

