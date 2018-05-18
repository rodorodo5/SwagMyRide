using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class UpdatingComplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "BreakId",
                table: "BreakCatalogue",
                newName: "BrakeId");

            migrationBuilder.CreateTable(
                name: "BoatBladesCatalogues",
                columns: table => new
                {
                    MotorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    HorsePower = table.Column<short>(nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatBladesCatalogues", x => x.MotorId);
                    table.ForeignKey(
                        name: "FK_BoatBladesCatalogues_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatBladesCatalogues_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BoatBladesCatalogues_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BoatBladesCatalogues_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TurbinesCatalogues",
                columns: table => new
                {
                    TurbinesId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Material = table.Column<string>(maxLength: 90, nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurbinesCatalogues", x => x.TurbinesId);
                    table.ForeignKey(
                        name: "FK_TurbinesCatalogues_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TurbinesCatalogues_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TurbinesCatalogues_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VehicleLand",
                columns: table => new
                {
                    VehicleLandId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BodyWorkId = table.Column<long>(nullable: false),
                    BrakeId = table.Column<long>(nullable: false),
                    Color = table.Column<string>(maxLength: 8, nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    ElecticSystemId = table.Column<long>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    MotorId = table.Column<long>(nullable: false),
                    SuspensionId = table.Column<long>(nullable: false),
                    TiresId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    VehicleBrandId = table.Column<long>(nullable: false),
                    VehicleModelId = table.Column<long>(nullable: false),
                    VehicleYear = table.Column<long>(nullable: false),
                    WheelId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleLand", x => x.VehicleLandId);
                    table.ForeignKey(
                        name: "FK_VehicleLand_BodyWorkCatalogue_BodyWorkId",
                        column: x => x.BodyWorkId,
                        principalTable: "BodyWorkCatalogue",
                        principalColumn: "BodyWorkId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_BreakCatalogue_BrakeId",
                        column: x => x.BrakeId,
                        principalTable: "BreakCatalogue",
                        principalColumn: "BrakeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_ElectricSystemCatalogue_ElecticSystemId",
                        column: x => x.ElecticSystemId,
                        principalTable: "ElectricSystemCatalogue",
                        principalColumn: "ElecticSystemId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_MotorCatalogue_MotorId",
                        column: x => x.MotorId,
                        principalTable: "MotorCatalogue",
                        principalColumn: "MotorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_SuspensionCatalogue_SuspensionId",
                        column: x => x.SuspensionId,
                        principalTable: "SuspensionCatalogue",
                        principalColumn: "SuspensionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_TiresCatalogue_TiresId",
                        column: x => x.TiresId,
                        principalTable: "TiresCatalogue",
                        principalColumn: "TiresId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleLand_WheelCatalogue_WheelId",
                        column: x => x.WheelId,
                        principalTable: "WheelCatalogue",
                        principalColumn: "WheelId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VehicleWater",
                columns: table => new
                {
                    VehicleLandId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoatBladesCount = table.Column<long>(nullable: false),
                    BoatBladesId = table.Column<long>(nullable: false),
                    BodyWorkId = table.Column<long>(nullable: false),
                    Color = table.Column<string>(maxLength: 8, nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    ElecticSystemId = table.Column<long>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    MotorId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    VehicleBrandId = table.Column<long>(nullable: false),
                    VehicleModelId = table.Column<long>(nullable: false),
                    VehicleYear = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleWater", x => x.VehicleLandId);
                    table.ForeignKey(
                        name: "FK_VehicleWater_BoatBladesCatalogues_BoatBladesId",
                        column: x => x.BoatBladesId,
                        principalTable: "BoatBladesCatalogues",
                        principalColumn: "MotorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_BodyWorkCatalogue_BodyWorkId",
                        column: x => x.BodyWorkId,
                        principalTable: "BodyWorkCatalogue",
                        principalColumn: "BodyWorkId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_ElectricSystemCatalogue_ElecticSystemId",
                        column: x => x.ElecticSystemId,
                        principalTable: "ElectricSystemCatalogue",
                        principalColumn: "ElecticSystemId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_MotorCatalogue_MotorId",
                        column: x => x.MotorId,
                        principalTable: "MotorCatalogue",
                        principalColumn: "MotorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleWater_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VehicleAir",
                columns: table => new
                {
                    VehicleAirId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BodyWorkId = table.Column<long>(nullable: false),
                    Color = table.Column<string>(maxLength: 8, nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    ElecticSystemId = table.Column<long>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    TurbinesCount = table.Column<short>(nullable: false),
                    TurbinesId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    VehicleBrandId = table.Column<long>(nullable: false),
                    VehicleModelId = table.Column<long>(nullable: false),
                    VehicleYear = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAir", x => x.VehicleAirId);
                    table.ForeignKey(
                        name: "FK_VehicleAir_BodyWorkCatalogue_BodyWorkId",
                        column: x => x.BodyWorkId,
                        principalTable: "BodyWorkCatalogue",
                        principalColumn: "BodyWorkId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_ElectricSystemCatalogue_ElecticSystemId",
                        column: x => x.ElecticSystemId,
                        principalTable: "ElectricSystemCatalogue",
                        principalColumn: "ElecticSystemId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_TurbinesCatalogues_TurbinesId",
                        column: x => x.TurbinesId,
                        principalTable: "TurbinesCatalogues",
                        principalColumn: "TurbinesId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VehicleAir_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogues_Brand",
                table: "BoatBladesCatalogues",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogues_CombustibleId",
                table: "BoatBladesCatalogues",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogues_Manufactured",
                table: "BoatBladesCatalogues",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_BoatBladesCatalogues_VechileTypeId",
                table: "BoatBladesCatalogues",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogues_Brand",
                table: "TurbinesCatalogues",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogues_Manufactured",
                table: "TurbinesCatalogues",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_TurbinesCatalogues_VechileTypeId",
                table: "TurbinesCatalogues",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_BodyWorkId",
                table: "VehicleAir",
                column: "BodyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_CombustibleId",
                table: "VehicleAir",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_ElecticSystemId",
                table: "VehicleAir",
                column: "ElecticSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_TurbinesId",
                table: "VehicleAir",
                column: "TurbinesId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_UserProfileId",
                table: "VehicleAir",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_VechileTypeId",
                table: "VehicleAir",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_VehicleBrandId",
                table: "VehicleAir",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAir_VehicleModelId",
                table: "VehicleAir",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_BodyWorkId",
                table: "VehicleLand",
                column: "BodyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_BrakeId",
                table: "VehicleLand",
                column: "BrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_CombustibleId",
                table: "VehicleLand",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_ElecticSystemId",
                table: "VehicleLand",
                column: "ElecticSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_MotorId",
                table: "VehicleLand",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_SuspensionId",
                table: "VehicleLand",
                column: "SuspensionId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_TiresId",
                table: "VehicleLand",
                column: "TiresId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_UserProfileId",
                table: "VehicleLand",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_VechileTypeId",
                table: "VehicleLand",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_VehicleBrandId",
                table: "VehicleLand",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_VehicleModelId",
                table: "VehicleLand",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLand_WheelId",
                table: "VehicleLand",
                column: "WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_BoatBladesId",
                table: "VehicleWater",
                column: "BoatBladesId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_BodyWorkId",
                table: "VehicleWater",
                column: "BodyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_CombustibleId",
                table: "VehicleWater",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_ElecticSystemId",
                table: "VehicleWater",
                column: "ElecticSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_MotorId",
                table: "VehicleWater",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_UserProfileId",
                table: "VehicleWater",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_VechileTypeId",
                table: "VehicleWater",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_VehicleBrandId",
                table: "VehicleWater",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleWater_VehicleModelId",
                table: "VehicleWater",
                column: "VehicleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleAir");

            migrationBuilder.DropTable(
                name: "VehicleLand");

            migrationBuilder.DropTable(
                name: "VehicleWater");

            migrationBuilder.DropTable(
                name: "TurbinesCatalogues");

            migrationBuilder.DropTable(
                name: "BoatBladesCatalogues");

            migrationBuilder.RenameColumn(
                name: "BrakeId",
                table: "BreakCatalogue",
                newName: "BreakId");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BodyWorkId = table.Column<long>(nullable: false),
                    BreakId = table.Column<long>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    ElecticSystemId = table.Column<long>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    MotorId = table.Column<long>(nullable: false),
                    SuspensionId = table.Column<long>(nullable: false),
                    TiresId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false),
                    VechileTypeId = table.Column<short>(nullable: false),
                    VehicleBrandId = table.Column<long>(nullable: false),
                    VehicleModelId = table.Column<long>(nullable: false),
                    VehicleYear = table.Column<long>(nullable: false),
                    WheelId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_BodyWorkCatalogue_BodyWorkId",
                        column: x => x.BodyWorkId,
                        principalTable: "BodyWorkCatalogue",
                        principalColumn: "BodyWorkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_BreakCatalogue_BreakId",
                        column: x => x.BreakId,
                        principalTable: "BreakCatalogue",
                        principalColumn: "BreakId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_ElectricSystemCatalogue_ElecticSystemId",
                        column: x => x.ElecticSystemId,
                        principalTable: "ElectricSystemCatalogue",
                        principalColumn: "ElecticSystemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_MotorCatalogue_MotorId",
                        column: x => x.MotorId,
                        principalTable: "MotorCatalogue",
                        principalColumn: "MotorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_SuspensionCatalogue_SuspensionId",
                        column: x => x.SuspensionId,
                        principalTable: "SuspensionCatalogue",
                        principalColumn: "SuspensionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_TiresCatalogue_TiresId",
                        column: x => x.TiresId,
                        principalTable: "TiresCatalogue",
                        principalColumn: "TiresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleType_VechileTypeId",
                        column: x => x.VechileTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleBrands_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrands",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_WheelCatalogue_WheelId",
                        column: x => x.WheelId,
                        principalTable: "WheelCatalogue",
                        principalColumn: "WheelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyWorkId",
                table: "Vehicles",
                column: "BodyWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BreakId",
                table: "Vehicles",
                column: "BreakId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CombustibleId",
                table: "Vehicles",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ElecticSystemId",
                table: "Vehicles",
                column: "ElecticSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MotorId",
                table: "Vehicles",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SuspensionId",
                table: "Vehicles",
                column: "SuspensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TiresId",
                table: "Vehicles",
                column: "TiresId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserProfileId",
                table: "Vehicles",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VechileTypeId",
                table: "Vehicles",
                column: "VechileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleBrandId",
                table: "Vehicles",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelId",
                table: "Vehicles",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_WheelId",
                table: "Vehicles",
                column: "WheelId");
        }
    }
}
