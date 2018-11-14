DROP INDEX [UserNameIndex] ON [AspNetUsers];

GO

DROP INDEX [RoleNameIndex] ON [AspNetRoles];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'TipoHabitaciones') AND [c].[name] = N'HabitacionId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TipoHabitaciones] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [TipoHabitaciones] ALTER COLUMN [HabitacionId] int NOT NULL;
ALTER TABLE [TipoHabitaciones] ADD DEFAULT (((0))) FOR [HabitacionId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'EstadoHabitaciones') AND [c].[name] = N'HabitacionId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [EstadoHabitaciones] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [EstadoHabitaciones] ALTER COLUMN [HabitacionId] int NOT NULL;
ALTER TABLE [EstadoHabitaciones] ADD DEFAULT (((0))) FOR [HabitacionId];

GO

CREATE TABLE [UserInfo] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NULL,
    [EmpleadosId] int NOT NULL,
    [Password] nvarchar(max) NULL,
    CONSTRAINT [PK_UserInfo] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserInfo_Empleados_EmpleadosId] FOREIGN KEY ([EmpleadosId]) REFERENCES [Empleados] ([Id]) ON DELETE CASCADE
);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE ([NormalizedUserName] IS NOT NULL);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE ([NormalizedName] IS NOT NULL);

GO

CREATE UNIQUE INDEX [IX_UserInfo_EmpleadosId] ON [UserInfo] ([EmpleadosId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181111165224_CuentaEmpleado', N'2.0.3-rtm-10026');

GO

