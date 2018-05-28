using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChangingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_VehicleBase_VehicleBaseId1",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_VehicleBaseId1",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "VehicleBaseId1",
                table: "VehicleBase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VehicleBaseId1",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_VehicleBaseId1",
                table: "VehicleBase",
                column: "VehicleBaseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleBase_VehicleBaseId1",
                table: "VehicleBase",
                column: "VehicleBaseId1",
                principalTable: "VehicleBase",
                principalColumn: "VehicleBaseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
