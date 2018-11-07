ALTER TABLE [Habitacion] DROP CONSTRAINT [FK_Habitacion_Estato_idEstado];

GO

EXEC sp_rename N'Habitacion.idEstado', N'estadoid', N'COLUMN';

GO

EXEC sp_rename N'Habitacion.IX_Habitacion_idEstado', N'IX_Habitacion_estadoid', N'INDEX';

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estato_estadoid] FOREIGN KEY ([estadoid]) REFERENCES [Estato] ([id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031172827_EstadoHabitacion', N'2.0.3-rtm-10026');

GO

