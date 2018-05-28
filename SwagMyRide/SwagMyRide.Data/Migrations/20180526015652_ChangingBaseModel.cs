using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChangingBaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheelId",
                table: "VehicleBase",
                newName: "VehicleLand_WheelId");

            migrationBuilder.RenameColumn(
                name: "SuspensionId",
                table: "VehicleBase",
                newName: "VehicleLand_SuspensionId");

            migrationBuilder.RenameColumn(
                name: "MotorId",
                table: "VehicleBase",
                newName: "VehicleWater_MotorId");

            migrationBuilder.AddColumn<long>(
                name: "SuspensionId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "TurbinesCount",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TurbinesId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WheelId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MotorId",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BoatBladesCount",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BoatBladesId",
                table: "VehicleBase",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuspensionId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "TurbinesCount",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "TurbinesId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "WheelId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "BoatBladesCount",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "BoatBladesId",
                table: "VehicleBase");

            migrationBuilder.RenameColumn(
                name: "VehicleWater_MotorId",
                table: "VehicleBase",
                newName: "MotorId");

            migrationBuilder.RenameColumn(
                name: "VehicleLand_WheelId",
                table: "VehicleBase",
                newName: "WheelId");

            migrationBuilder.RenameColumn(
                name: "VehicleLand_SuspensionId",
                table: "VehicleBase",
                newName: "SuspensionId");
        }
    }
}
