using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApiHotel.Migrations
{
    public partial class Estado_Tipo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Habitacion_HabitacionId",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Habitacion_HabitacionId",
                table: "Tipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "TipoHabitaciones");

            migrationBuilder.RenameTable(
                name: "Habitacion",
                newName: "Habitaciones");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "EstadoHabitaciones");

            migrationBuilder.RenameColumn(
                name: "Tipo_Habitacion",
                table: "TipoHabitaciones",
                newName: "TipoHabitacion");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_HabitacionId",
                table: "TipoHabitaciones",
                newName: "IX_TipoHabitaciones_HabitacionId");

            migrationBuilder.RenameColumn(
                name: "Estado_Habitacion",
                table: "EstadoHabitaciones",
                newName: "EstadoHabitacion");

            migrationBuilder.RenameIndex(
                name: "IX_Estado_HabitacionId",
                table: "EstadoHabitaciones",
                newName: "IX_EstadoHabitaciones_HabitacionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoHabitaciones",
                table: "TipoHabitaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones",
                column: "Codigo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoHabitaciones",
                table: "EstadoHabitaciones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoHabitaciones_Habitaciones_HabitacionId",
                table: "EstadoHabitaciones",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoHabitaciones_Habitaciones_HabitacionId",
                table: "TipoHabitaciones",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstadoHabitaciones_Habitaciones_HabitacionId",
                table: "EstadoHabitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoHabitaciones_Habitaciones_HabitacionId",
                table: "TipoHabitaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoHabitaciones",
                table: "TipoHabitaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoHabitaciones",
                table: "EstadoHabitaciones");

            migrationBuilder.RenameTable(
                name: "TipoHabitaciones",
                newName: "Tipo");

            migrationBuilder.RenameTable(
                name: "Habitaciones",
                newName: "Habitacion");

            migrationBuilder.RenameTable(
                name: "EstadoHabitaciones",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "TipoHabitacion",
                table: "Tipo",
                newName: "Tipo_Habitacion");

            migrationBuilder.RenameIndex(
                name: "IX_TipoHabitaciones_HabitacionId",
                table: "Tipo",
                newName: "IX_Tipo_HabitacionId");

            migrationBuilder.RenameColumn(
                name: "EstadoHabitacion",
                table: "Estado",
                newName: "Estado_Habitacion");

            migrationBuilder.RenameIndex(
                name: "IX_EstadoHabitaciones_HabitacionId",
                table: "Estado",
                newName: "IX_Estado_HabitacionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion",
                column: "Codigo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Habitacion_HabitacionId",
                table: "Estado",
                column: "HabitacionId",
                principalTable: "Habitacion",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Habitacion_HabitacionId",
                table: "Tipo",
                column: "HabitacionId",
                principalTable: "Habitacion",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
