using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingNameToVehicleBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "VechileBrandName",
                table: "VehicleBase",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<long>(
                name: "VehicleModelName",
                table: "VehicleBase",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VechileBrandName",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "VehicleModelName",
                table: "VehicleBase");
        }
    }
}
