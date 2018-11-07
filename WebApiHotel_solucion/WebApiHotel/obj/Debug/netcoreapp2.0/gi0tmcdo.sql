ALTER TABLE [Habitacion] DROP CONSTRAINT [FK_Habitacion_Estado_estadoid];

GO

DROP INDEX [IX_Habitacion_estadoid] ON [Habitacion];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'Habitacion') AND [c].[name] = N'estadoid');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Habitacion] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Habitacion] DROP COLUMN [estadoid];

GO

ALTER TABLE [Estado] ADD [codHabitacion] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Estado] ADD [habitacionescodigo] int NULL;

GO

CREATE INDEX [IX_Estado_habitacionescodigo] ON [Estado] ([habitacionescodigo]);

GO

ALTER TABLE [Estado] ADD CONSTRAINT [FK_Estado_Habitacion_habitacionescodigo] FOREIGN KEY ([habitacionescodigo]) REFERENCES [Habitacion] ([codigo]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031004023_EstadoHabitacion', N'2.0.3-rtm-10026');

GO

