using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class EraseDataFromTurbine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataToRease",
                table: "TurbinesCatalogue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DataToRease",
                table: "TurbinesCatalogue",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
