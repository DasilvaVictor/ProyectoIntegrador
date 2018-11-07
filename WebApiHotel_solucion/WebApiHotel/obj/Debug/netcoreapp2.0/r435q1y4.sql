ALTER TABLE [Habitacion] ADD [id] int NOT NULL DEFAULT 0;

GO

CREATE TABLE [Estato] (
    [id] int NOT NULL ,
    [estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Estato] PRIMARY KEY ([id])
);

GO

CREATE INDEX [IX_Habitacion_id] ON [Habitacion] ([id]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estato_id] FOREIGN KEY ([id]) REFERENCES [Estato] ([id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031172058_EstadoHabitacion', N'2.0.3-rtm-10026');

GO

