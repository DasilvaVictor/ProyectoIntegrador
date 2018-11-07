ALTER TABLE [Estado] DROP CONSTRAINT [FK_Estado_Habitacion_habitacionescodigo];

GO

DROP INDEX [IX_Estado_habitacionescodigo] ON [Estado];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'Estado') AND [c].[name] = N'habitacionescodigo');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Estado] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Estado] DROP COLUMN [habitacionescodigo];

GO

ALTER TABLE [Habitacion] ADD [estadoid] int NULL;

GO

CREATE INDEX [IX_Habitacion_estadoid] ON [Habitacion] ([estadoid]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estado_estadoid] FOREIGN KEY ([estadoid]) REFERENCES [Estado] ([id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031005412_EstadoHabitacion3', N'2.0.3-rtm-10026');

GO

