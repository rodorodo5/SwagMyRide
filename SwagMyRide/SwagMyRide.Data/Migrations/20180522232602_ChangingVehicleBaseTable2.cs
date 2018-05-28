using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChangingVehicleBaseTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BrakeId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SuspensionId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TiresId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WheelId",
                table: "VehicleBase",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrakeId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "SuspensionId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "TiresId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "WheelId",
                table: "VehicleBase");
        }
    }
}
