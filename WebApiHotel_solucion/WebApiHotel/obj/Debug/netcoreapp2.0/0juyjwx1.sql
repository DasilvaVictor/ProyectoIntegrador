ALTER TABLE [Habitacion] DROP CONSTRAINT [FK_Habitacion_Estado_estadoid];

GO

ALTER TABLE [Estado] DROP CONSTRAINT [PK_Estado];

GO

EXEC sp_rename N'Estado', N'Estato';

GO

ALTER TABLE [Estato] ADD CONSTRAINT [PK_Estato] PRIMARY KEY ([id]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estato_estadoid] FOREIGN KEY ([estadoid]) REFERENCES [Estato] ([id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031162441_Estado', N'2.0.3-rtm-10026');

GO

