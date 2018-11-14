DROP TABLE [UserInfo];

GO

ALTER TABLE [AspNetUsers] ADD [EmpleadosId] int NOT NULL DEFAULT 0;

GO

CREATE UNIQUE INDEX [IX_AspNetUsers_EmpleadosId] ON [AspNetUsers] ([EmpleadosId]);

GO

ALTER TABLE [AspNetUsers] ADD CONSTRAINT [FK_AspNetUsers_Empleados_EmpleadosId] FOREIGN KEY ([EmpleadosId]) REFERENCES [Empleados] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181111170435_EmpleadoCuenta', N'2.0.3-rtm-10026');

GO

