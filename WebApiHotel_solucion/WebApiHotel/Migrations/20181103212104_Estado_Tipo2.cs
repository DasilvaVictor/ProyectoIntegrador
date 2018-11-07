using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApiHotel.Migrations
{
    public partial class Estado_Tipo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_Estado_EstadoId",
                table: "Habitacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_Tipo_TipoId",
                table: "Habitacion");

            migrationBuilder.DropIndex(
                name: "IX_Habitacion_EstadoId",
                table: "Habitacion");

            migrationBuilder.DropIndex(
                name: "IX_Habitacion_TipoId",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Habitacion");

            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Tipo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Estado",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_HabitacionId",
                table: "Tipo",
                column: "HabitacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_HabitacionId",
                table: "Estado",
                column: "HabitacionId",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Habitacion_HabitacionId",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Habitacion_HabitacionId",
                table: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Tipo_HabitacionId",
                table: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Estado_HabitacionId",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Tipo");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Estado");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Habitacion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Habitacion",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_EstadoId",
                table: "Habitacion",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_TipoId",
                table: "Habitacion",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_Estado_EstadoId",
                table: "Habitacion",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_Tipo_TipoId",
                table: "Habitacion",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
