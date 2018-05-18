using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingCombustibleIdToTuribnes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CombustibleId",
                table: "TurbinesCatalogue",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogue_CombustibleId",
                table: "TurbinesCatalogue",
                column: "CombustibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_CombustibleType_CombustibleId",
                table: "TurbinesCatalogue",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_CombustibleType_CombustibleId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropIndex(
                name: "IX_TurbinesCatalogue_CombustibleId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropColumn(
                name: "CombustibleId",
                table: "TurbinesCatalogue");
        }
    }
}
