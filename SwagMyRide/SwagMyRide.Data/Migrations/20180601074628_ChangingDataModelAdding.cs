using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChangingDataModelAdding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "WheelCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "TurbinesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "TiresCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "SuspensionCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "OrderList",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "OrderList",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderList",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderList",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "UserVehicleBaseId",
                table: "OrderList",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "MotorCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "ElectricSystemCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "BreakCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "BodyWorkCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "BoatBladesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ComponentType",
                columns: table => new
                {
                    ComponentTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentType", x => x.ComponentTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WheelCatalogue_ComponentTypeId",
                table: "WheelCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogue_ComponentTypeId",
                table: "TurbinesCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TiresCatalogue_ComponentTypeId",
                table: "TiresCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuspensionCatalogue_ComponentTypeId",
                table: "SuspensionCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_UserVehicleBaseId",
                table: "OrderList",
                column: "UserVehicleBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_ComponentTypeId",
                table: "MotorCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricSystemCatalogue_ComponentTypeId",
                table: "ElectricSystemCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakCatalogue_ComponentTypeId",
                table: "BreakCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyWorkCatalogue_ComponentTypeId",
                table: "BodyWorkCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogue_ComponentTypeId",
                table: "BoatBladesCatalogue",
                column: "ComponentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_ComponentType_ComponentTypeId",
                table: "BoatBladesCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyWorkCatalogue_ComponentType_ComponentTypeId",
                table: "BodyWorkCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BreakCatalogue_ComponentType_ComponentTypeId",
                table: "BreakCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricSystemCatalogue_ComponentType_ComponentTypeId",
                table: "ElectricSystemCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotorCatalogue_ComponentType_ComponentTypeId",
                table: "MotorCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderList_VehicleBase_UserVehicleBaseId",
                table: "OrderList",
                column: "UserVehicleBaseId",
                principalTable: "VehicleBase",
                principalColumn: "VehicleBaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuspensionCatalogue_ComponentType_ComponentTypeId",
                table: "SuspensionCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TiresCatalogue_ComponentType_ComponentTypeId",
                table: "TiresCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_ComponentType_ComponentTypeId",
                table: "TurbinesCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WheelCatalogue_ComponentType_ComponentTypeId",
                table: "WheelCatalogue",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_ComponentType_ComponentTypeId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyWorkCatalogue_ComponentType_ComponentTypeId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BreakCatalogue_ComponentType_ComponentTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricSystemCatalogue_ComponentType_ComponentTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_MotorCatalogue_ComponentType_ComponentTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderList_VehicleBase_UserVehicleBaseId",
                table: "OrderList");

            migrationBuilder.DropForeignKey(
                name: "FK_SuspensionCatalogue_ComponentType_ComponentTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TiresCatalogue_ComponentType_ComponentTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_ComponentType_ComponentTypeId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_WheelCatalogue_ComponentType_ComponentTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropTable(
                name: "ComponentType");

            migrationBuilder.DropIndex(
                name: "IX_WheelCatalogue_ComponentTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_TurbinesCatalogue_ComponentTypeId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_TiresCatalogue_ComponentTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_SuspensionCatalogue_ComponentTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_OrderList_UserVehicleBaseId",
                table: "OrderList");

            migrationBuilder.DropIndex(
                name: "IX_MotorCatalogue_ComponentTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_ElectricSystemCatalogue_ComponentTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BreakCatalogue_ComponentTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BodyWorkCatalogue_ComponentTypeId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_BoatBladesCatalogue_ComponentTypeId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "WheelCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "TiresCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "SuspensionCatalogue");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "UserVehicleBaseId",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "MotorCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "ElectricSystemCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "BreakCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "BodyWorkCatalogue");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "BoatBladesCatalogue");
        }
    }
}
