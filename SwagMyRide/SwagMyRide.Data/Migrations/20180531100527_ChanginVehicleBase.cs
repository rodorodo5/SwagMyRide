using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChanginVehicleBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleModelName",
                table: "VehicleBase",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "VechileBrandName",
                table: "VehicleBase",
                nullable: false,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "VehicleModelName",
                table: "VehicleBase",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<short>(
                name: "VechileBrandName",
                table: "VehicleBase",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
