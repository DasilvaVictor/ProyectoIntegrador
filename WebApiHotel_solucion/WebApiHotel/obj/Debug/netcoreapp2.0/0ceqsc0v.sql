ALTER TABLE [Habitacion] ADD [estadoid] int NULL;

GO

CREATE TABLE [Estado] (
    [id] int NOT NULL IDENTITY,
    [estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Estado] PRIMARY KEY ([id])
);

GO

CREATE INDEX [IX_Habitacion_estadoid] ON [Habitacion] ([estadoid]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estado_estadoid] FOREIGN KEY ([estadoid]) REFERENCES [Estado] ([id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181030235437_AgregandoEstado_Habitacion', N'2.0.3-rtm-10026');

GO

