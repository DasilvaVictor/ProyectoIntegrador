ALTER TABLE [Habitacion] ADD [idEstado] int NOT NULL DEFAULT 0;

GO

CREATE TABLE [Estato] (
    [id] int NOT NULL,
    [estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Estato] PRIMARY KEY ([id])
);

GO

CREATE INDEX [IX_Habitacion_idEstado] ON [Habitacion] ([idEstado]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estato_idEstado] FOREIGN KEY ([idEstado]) REFERENCES [Estato] ([id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031171815_EstadoHabitacion', N'2.0.3-rtm-10026');

GO

