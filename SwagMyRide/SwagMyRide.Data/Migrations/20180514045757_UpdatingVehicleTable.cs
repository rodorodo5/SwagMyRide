using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class UpdatingVehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BodyWorkCatalogue_BodyWorkId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BreakCatalogue_BreakId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BodyWorkCatalogueId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BreakCatalogueId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<long>(
                name: "BreakId",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BodyWorkId",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BodyWorkCatalogue_BodyWorkId",
                table: "Vehicles",
                column: "BodyWorkId",
                principalTable: "BodyWorkCatalogue",
                principalColumn: "BodyWorkId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BreakCatalogue_BreakId",
                table: "Vehicles",
                column: "BreakId",
                principalTable: "BreakCatalogue",
                principalColumn: "BreakId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BodyWorkCatalogue_BodyWorkId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BreakCatalogue_BreakId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<long>(
                name: "BreakId",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "BodyWorkId",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "BodyWorkCatalogueId",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BreakCatalogueId",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BodyWorkCatalogue_BodyWorkId",
                table: "Vehicles",
                column: "BodyWorkId",
                principalTable: "BodyWorkCatalogue",
                principalColumn: "BodyWorkId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BreakCatalogue_BreakId",
                table: "Vehicles",
                column: "BreakId",
                principalTable: "BreakCatalogue",
                principalColumn: "BreakId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
