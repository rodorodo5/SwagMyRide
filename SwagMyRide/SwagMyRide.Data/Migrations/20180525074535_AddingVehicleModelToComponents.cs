using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingVehicleModelToComponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "WheelCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DataToRease",
                table: "TurbinesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "TurbinesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "TiresCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "SuspensionCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "MotorCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "ElectricSystemCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "BreakCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "BodyWorkCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelId",
                table: "BoatBladesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_WheelCatalogue_VehicleModelId",
                table: "WheelCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogue_VehicleModelId",
                table: "TurbinesCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TiresCatalogue_VehicleModelId",
                table: "TiresCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SuspensionCatalogue_VehicleModelId",
                table: "SuspensionCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_VehicleModelId",
                table: "MotorCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricSystemCatalogue_VehicleModelId",
                table: "ElectricSystemCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakCatalogue_VehicleModelId",
                table: "BreakCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyWorkCatalogue_VehicleModelId",
                table: "BodyWorkCatalogue",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogue_VehicleModelId",
                table: "BoatBladesCatalogue",
                column: "VehicleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_VehicleModels_VehicleModelId",
                table: "BoatBladesCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyWorkCatalogue_VehicleModels_VehicleModelId",
                table: "BodyWorkCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BreakCatalogue_VehicleModels_VehicleModelId",
                table: "BreakCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricSystemCatalogue_VehicleModels_VehicleModelId",
                table: "ElectricSystemCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotorCatalogue_VehicleModels_VehicleModelId",
                table: "MotorCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuspensionCatalogue_VehicleModels_VehicleModelId",
                table: "SuspensionCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TiresCatalogue_VehicleModels_VehicleModelId",
                table: "TiresCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_VehicleModels_VehicleModelId",
                table: "TurbinesCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WheelCatalogue_VehicleModels_VehicleModelId",
                table: "WheelCatalogue",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_VehicleModels_VehicleModelId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyWorkCatalogue_VehicleModels_VehicleModelId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BreakCatalogue_VehicleModels_VehicleModelId",
                table: "BreakCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricSystemCatalogue_VehicleModels_VehicleModelId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_MotorCatalogue_VehicleModels_VehicleModelId",
                table: "MotorCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_SuspensionCatalogue_VehicleModels_VehicleModelId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TiresCatalogue_VehicleModels_VehicleModelId",
                table: "TiresCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_VehicleModels_VehicleModelId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_WheelCatalogue_VehicleModels_VehicleModelId",
                table: "WheelCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_WheelCatalogue_VehicleModelId",
                table: "WheelCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_TurbinesCatalogue_VehicleModelId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_TiresCatalogue_VehicleModelId",
                table: "TiresCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_SuspensionCatalogue_VehicleModelId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_MotorCatalogue_VehicleModelId",
                table: "MotorCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_ElectricSystemCatalogue_VehicleModelId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BreakCatalogue_VehicleModelId",
                table: "BreakCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BodyWorkCatalogue_VehicleModelId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BoatBladesCatalogue_VehicleModelId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "WheelCatalogue");

            migrationBuilder.DropColumn(
                name: "DataToRease",
                table: "TurbinesCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "TiresCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "MotorCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "BreakCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "BoatBladesCatalogue");
        }
    }
}
