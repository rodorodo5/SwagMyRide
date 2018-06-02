using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingBrakeAndMotorToAirVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotorId",
                table: "VehicleBase",
                newName: "VehicleLand_MotorId");

            migrationBuilder.RenameColumn(
                name: "BrakeId",
                table: "VehicleBase",
                newName: "VehicleLand_BrakeId");

            migrationBuilder.AddColumn<long>(
                name: "BrakeId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MotorId",
                table: "VehicleBase",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrakeId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "VehicleBase");

            migrationBuilder.RenameColumn(
                name: "VehicleLand_MotorId",
                table: "VehicleBase",
                newName: "MotorId");

            migrationBuilder.RenameColumn(
                name: "VehicleLand_BrakeId",
                table: "VehicleBase",
                newName: "BrakeId");
        }
    }
}
