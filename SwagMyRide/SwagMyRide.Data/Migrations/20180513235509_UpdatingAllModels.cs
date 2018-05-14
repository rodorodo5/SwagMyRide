using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class UpdatingAllModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "WheelCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "Vehicles",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VehicleTypeId",
                table: "VehicleModels",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VehicleTypeId",
                table: "VehicleBrands",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "TiresCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "SuspensionCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "MotorCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "ElectricSystemCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "BreakCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "BrandCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "VechileTypeId",
                table: "BodyWorkCatalogue",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    VehicleTypeId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleTypeName = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WheelCatalogue_VechileTypeId",
                table: "WheelCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VechileTypeId",
                table: "Vehicles",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_VehicleTypeId",
                table: "VehicleModels",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrands_VehicleTypeId",
                table: "VehicleBrands",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TiresCatalogue_VechileTypeId",
                table: "TiresCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuspensionCatalogue_VechileTypeId",
                table: "SuspensionCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_VechileTypeId",
                table: "MotorCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricSystemCatalogue_VechileTypeId",
                table: "ElectricSystemCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakCatalogue_VechileTypeId",
                table: "BreakCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandCatalogue_VechileTypeId",
                table: "BrandCatalogue",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyWorkCatalogue_VechileTypeId",
                table: "BodyWorkCatalogue",
                column: "VechileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyWorkCatalogue_VehicleType_VechileTypeId",
                table: "BodyWorkCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_BrandCatalogue_VehicleType_VechileTypeId",
                table: "BrandCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_BreakCatalogue_VehicleType_VechileTypeId",
                table: "BreakCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricSystemCatalogue_VehicleType_VechileTypeId",
                table: "ElectricSystemCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MotorCatalogue_VehicleType_VechileTypeId",
                table: "MotorCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SuspensionCatalogue_VehicleType_VechileTypeId",
                table: "SuspensionCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TiresCatalogue_VehicleType_VechileTypeId",
                table: "TiresCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBrands_VehicleType_VehicleTypeId",
                table: "VehicleBrands",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_VehicleType_VehicleTypeId",
                table: "VehicleModels",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleType_VechileTypeId",
                table: "Vehicles",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_WheelCatalogue_VehicleType_VechileTypeId",
                table: "WheelCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyWorkCatalogue_VehicleType_VechileTypeId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BrandCatalogue_VehicleType_VechileTypeId",
                table: "BrandCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BreakCatalogue_VehicleType_VechileTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricSystemCatalogue_VehicleType_VechileTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_MotorCatalogue_VehicleType_VechileTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_SuspensionCatalogue_VehicleType_VechileTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TiresCatalogue_VehicleType_VechileTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBrands_VehicleType_VehicleTypeId",
                table: "VehicleBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_VehicleType_VehicleTypeId",
                table: "VehicleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleType_VechileTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_WheelCatalogue_VehicleType_VechileTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_WheelCatalogue_VechileTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VechileTypeId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModels_VehicleTypeId",
                table: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBrands_VehicleTypeId",
                table: "VehicleBrands");

            migrationBuilder.DropIndex(
                name: "IX_TiresCatalogue_VechileTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_SuspensionCatalogue_VechileTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_MotorCatalogue_VechileTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_ElectricSystemCatalogue_VechileTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BreakCatalogue_VechileTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BrandCatalogue_VechileTypeId",
                table: "BrandCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BodyWorkCatalogue_VechileTypeId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                table: "VehicleBrands");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "BrandCatalogue");

            migrationBuilder.DropColumn(
                name: "VechileTypeId",
                table: "BodyWorkCatalogue");
        }
    }
}
