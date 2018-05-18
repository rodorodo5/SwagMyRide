using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class ChanginTableNamesBoatTurbine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogues_BrandCatalogue_Brand",
                table: "BoatBladesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogues_CombustibleType_CombustibleId",
                table: "BoatBladesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogues_Country_Manufactured",
                table: "BoatBladesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogues_VehicleType_VechileTypeId",
                table: "BoatBladesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogues_BrandCatalogue_Brand",
                table: "TurbinesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogues_Country_Manufactured",
                table: "TurbinesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogues_VehicleType_VechileTypeId",
                table: "TurbinesCatalogues");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAir_TurbinesCatalogues_TurbinesId",
                table: "VehicleAir");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleWater_BoatBladesCatalogues_BoatBladesId",
                table: "VehicleWater");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurbinesCatalogues",
                table: "TurbinesCatalogues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatBladesCatalogues",
                table: "BoatBladesCatalogues");

            migrationBuilder.RenameTable(
                name: "TurbinesCatalogues",
                newName: "TurbinesCatalogue");

            migrationBuilder.RenameTable(
                name: "BoatBladesCatalogues",
                newName: "BoatBladesCatalogue");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogues_VechileTypeId",
                table: "TurbinesCatalogue",
                newName: "IX_TurbinesCatalogue_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogues_Manufactured",
                table: "TurbinesCatalogue",
                newName: "IX_TurbinesCatalogue_Manufactured");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogues_Brand",
                table: "TurbinesCatalogue",
                newName: "IX_TurbinesCatalogue_Brand");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogues_VechileTypeId",
                table: "BoatBladesCatalogue",
                newName: "IX_BoatBladesCatalogue_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogues_Manufactured",
                table: "BoatBladesCatalogue",
                newName: "IX_BoatBladesCatalogue_Manufactured");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogues_CombustibleId",
                table: "BoatBladesCatalogue",
                newName: "IX_BoatBladesCatalogue_CombustibleId");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogues_Brand",
                table: "BoatBladesCatalogue",
                newName: "IX_BoatBladesCatalogue_Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurbinesCatalogue",
                table: "TurbinesCatalogue",
                column: "TurbinesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatBladesCatalogue",
                table: "BoatBladesCatalogue",
                column: "BoatBladesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_BrandCatalogue_Brand",
                table: "BoatBladesCatalogue",
                column: "Brand",
                principalTable: "BrandCatalogue",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_CombustibleType_CombustibleId",
                table: "BoatBladesCatalogue",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_Country_Manufactured",
                table: "BoatBladesCatalogue",
                column: "Manufactured",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogue_VehicleType_VechileTypeId",
                table: "BoatBladesCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_BrandCatalogue_Brand",
                table: "TurbinesCatalogue",
                column: "Brand",
                principalTable: "BrandCatalogue",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_Country_Manufactured",
                table: "TurbinesCatalogue",
                column: "Manufactured",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogue_VehicleType_VechileTypeId",
                table: "TurbinesCatalogue",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAir_TurbinesCatalogue_TurbinesId",
                table: "VehicleAir",
                column: "TurbinesId",
                principalTable: "TurbinesCatalogue",
                principalColumn: "TurbinesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleWater_BoatBladesCatalogue_BoatBladesId",
                table: "VehicleWater",
                column: "BoatBladesId",
                principalTable: "BoatBladesCatalogue",
                principalColumn: "BoatBladesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_BrandCatalogue_Brand",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_CombustibleType_CombustibleId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_Country_Manufactured",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatBladesCatalogue_VehicleType_VechileTypeId",
                table: "BoatBladesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_BrandCatalogue_Brand",
                table: "TurbinesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_Country_Manufactured",
                table: "TurbinesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbinesCatalogue_VehicleType_VechileTypeId",
                table: "TurbinesCatalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAir_TurbinesCatalogue_TurbinesId",
                table: "VehicleAir");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleWater_BoatBladesCatalogue_BoatBladesId",
                table: "VehicleWater");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurbinesCatalogue",
                table: "TurbinesCatalogue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatBladesCatalogue",
                table: "BoatBladesCatalogue");

            migrationBuilder.RenameTable(
                name: "TurbinesCatalogue",
                newName: "TurbinesCatalogues");

            migrationBuilder.RenameTable(
                name: "BoatBladesCatalogue",
                newName: "BoatBladesCatalogues");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogue_VechileTypeId",
                table: "TurbinesCatalogues",
                newName: "IX_TurbinesCatalogues_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogue_Manufactured",
                table: "TurbinesCatalogues",
                newName: "IX_TurbinesCatalogues_Manufactured");

            migrationBuilder.RenameIndex(
                name: "IX_TurbinesCatalogue_Brand",
                table: "TurbinesCatalogues",
                newName: "IX_TurbinesCatalogues_Brand");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogue_VechileTypeId",
                table: "BoatBladesCatalogues",
                newName: "IX_BoatBladesCatalogues_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogue_Manufactured",
                table: "BoatBladesCatalogues",
                newName: "IX_BoatBladesCatalogues_Manufactured");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogue_CombustibleId",
                table: "BoatBladesCatalogues",
                newName: "IX_BoatBladesCatalogues_CombustibleId");

            migrationBuilder.RenameIndex(
                name: "IX_BoatBladesCatalogue_Brand",
                table: "BoatBladesCatalogues",
                newName: "IX_BoatBladesCatalogues_Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurbinesCatalogues",
                table: "TurbinesCatalogues",
                column: "TurbinesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatBladesCatalogues",
                table: "BoatBladesCatalogues",
                column: "BoatBladesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogues_BrandCatalogue_Brand",
                table: "BoatBladesCatalogues",
                column: "Brand",
                principalTable: "BrandCatalogue",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogues_CombustibleType_CombustibleId",
                table: "BoatBladesCatalogues",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogues_Country_Manufactured",
                table: "BoatBladesCatalogues",
                column: "Manufactured",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatBladesCatalogues_VehicleType_VechileTypeId",
                table: "BoatBladesCatalogues",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogues_BrandCatalogue_Brand",
                table: "TurbinesCatalogues",
                column: "Brand",
                principalTable: "BrandCatalogue",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogues_Country_Manufactured",
                table: "TurbinesCatalogues",
                column: "Manufactured",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbinesCatalogues_VehicleType_VechileTypeId",
                table: "TurbinesCatalogues",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAir_TurbinesCatalogues_TurbinesId",
                table: "VehicleAir",
                column: "TurbinesId",
                principalTable: "TurbinesCatalogues",
                principalColumn: "TurbinesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleWater_BoatBladesCatalogues_BoatBladesId",
                table: "VehicleWater",
                column: "BoatBladesId",
                principalTable: "BoatBladesCatalogues",
                principalColumn: "BoatBladesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
