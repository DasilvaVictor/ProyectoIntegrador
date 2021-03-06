﻿ALTER TABLE [Habitacion] ADD [estadoid] int NULL;

GO

CREATE TABLE [Estato] (
    [id] int NOT NULL IDENTITY,
    [codHabitacion] int NOT NULL,
    [estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Estato] PRIMARY KEY ([id])
);

GO

CREATE INDEX [IX_Habitacion_estadoid] ON [Habitacion] ([estadoid]);

GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Estato_estadoid] FOREIGN KEY ([estadoid]) REFERENCES [Estato] ([id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181031163903_EstadoHabitacion', N'2.0.3-rtm-10026');

GO

