using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChangingVehicleBaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_BodyWorkCatalogue_BodyWorkId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_CombustibleType_CombustibleId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_ElectricSystemCatalogue_ElecticSystemId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_UserProfile_UserProfileId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_VehicleType_VechileTypeId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_VehicleBrands_VehicleBrandId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_VehicleModels_VehicleModelId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_BreakCatalogue_BrakeId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_MotorCatalogue_MotorId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_SuspensionCatalogue_SuspensionId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_TiresCatalogue_TiresId",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_WheelCatalogue_WheelId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_BodyWorkId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_CombustibleId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_ElecticSystemId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_UserProfileId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_VechileTypeId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_VehicleBrandId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_VehicleModelId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_BrakeId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_MotorId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_SuspensionId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_TiresId",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_WheelId",
                table: "VehicleBase");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_BodyWorkId",
                table: "VehicleBase",
                column: "BodyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_CombustibleId",
                table: "VehicleBase",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_ElecticSystemId",
                table: "VehicleBase",
                column: "ElecticSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_UserProfileId",
                table: "VehicleBase",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_VechileTypeId",
                table: "VehicleBase",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_VehicleBrandId",
                table: "VehicleBase",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_VehicleModelId",
                table: "VehicleBase",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_BrakeId",
                table: "VehicleBase",
                column: "BrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_MotorId",
                table: "VehicleBase",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_SuspensionId",
                table: "VehicleBase",
                column: "SuspensionId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_TiresId",
                table: "VehicleBase",
                column: "TiresId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_WheelId",
                table: "VehicleBase",
                column: "WheelId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_BodyWorkCatalogue_BodyWorkId",
                table: "VehicleBase",
                column: "BodyWorkId",
                principalTable: "BodyWorkCatalogue",
                principalColumn: "BodyWorkId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_CombustibleType_CombustibleId",
                table: "VehicleBase",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_ElectricSystemCatalogue_ElecticSystemId",
                table: "VehicleBase",
                column: "ElecticSystemId",
                principalTable: "ElectricSystemCatalogue",
                principalColumn: "ElecticSystemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_UserProfile_UserProfileId",
                table: "VehicleBase",
                column: "UserProfileId",
                principalTable: "UserProfile",
                principalColumn: "UserProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleType_VechileTypeId",
                table: "VehicleBase",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleBrands_VehicleBrandId",
                table: "VehicleBase",
                column: "VehicleBrandId",
                principalTable: "VehicleBrands",
                principalColumn: "VehicleBrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleModels_VehicleModelId",
                table: "VehicleBase",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_BreakCatalogue_BrakeId",
                table: "VehicleBase",
                column: "BrakeId",
                principalTable: "BreakCatalogue",
                principalColumn: "BrakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_MotorCatalogue_MotorId",
                table: "VehicleBase",
                column: "MotorId",
                principalTable: "MotorCatalogue",
                principalColumn: "MotorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_SuspensionCatalogue_SuspensionId",
                table: "VehicleBase",
                column: "SuspensionId",
                principalTable: "SuspensionCatalogue",
                principalColumn: "SuspensionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_TiresCatalogue_TiresId",
                table: "VehicleBase",
                column: "TiresId",
                principalTable: "TiresCatalogue",
                principalColumn: "TiresId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_WheelCatalogue_WheelId",
                table: "VehicleBase",
                column: "WheelId",
                principalTable: "WheelCatalogue",
                principalColumn: "WheelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
