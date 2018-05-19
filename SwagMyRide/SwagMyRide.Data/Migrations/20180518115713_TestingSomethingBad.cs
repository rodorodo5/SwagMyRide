using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class TestingSomethingBad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_BodyWorkCatalogue_BodyWorkId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_BreakCatalogue_BrakeId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_CombustibleType_CombustibleId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_ElectricSystemCatalogue_ElecticSystemId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_MotorCatalogue_MotorId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_SuspensionCatalogue_SuspensionId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_TiresCatalogue_TiresId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_UserProfile_UserProfileId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_VehicleType_VechileTypeId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_VehicleBrands_VehicleBrandId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_VehicleModels_VehicleModelId",
                table: "VehicleLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleLand_WheelCatalogue_WheelId",
                table: "VehicleLand");

            migrationBuilder.DropTable(
                name: "VehicleAir");

            migrationBuilder.DropTable(
                name: "VehicleWater");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleLand",
                table: "VehicleLand");

            migrationBuilder.RenameTable(
                name: "VehicleLand",
                newName: "VehicleBase");

            migrationBuilder.RenameColumn(
                name: "VehicleLandId",
                table: "VehicleBase",
                newName: "VehicleBaseId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_WheelId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_WheelId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_VehicleModelId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_VehicleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_VehicleBrandId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_VehicleBrandId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_VechileTypeId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_UserProfileId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_TiresId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_TiresId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_SuspensionId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_SuspensionId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_MotorId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_MotorId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_ElecticSystemId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_ElecticSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_CombustibleId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_CombustibleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_BrakeId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_BrakeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleLand_BodyWorkId",
                table: "VehicleBase",
                newName: "IX_VehicleBase_BodyWorkId");

            migrationBuilder.AlterColumn<long>(
                name: "WheelId",
                table: "VehicleBase",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "TiresId",
                table: "VehicleBase",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "SuspensionId",
                table: "VehicleBase",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "MotorId",
                table: "VehicleBase",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "BrakeId",
                table: "VehicleBase",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "VehicleBase",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "VehicleBaseId1",
                table: "VehicleBase",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleBase",
                table: "VehicleBase",
                column: "VehicleBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBase_VehicleBaseId1",
                table: "VehicleBase",
                column: "VehicleBaseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_BodyWorkCatalogue_BodyWorkId",
                table: "VehicleBase",
                column: "BodyWorkId",
                principalTable: "BodyWorkCatalogue",
                principalColumn: "BodyWorkId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_CombustibleType_CombustibleId",
                table: "VehicleBase",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_ElectricSystemCatalogue_ElecticSystemId",
                table: "VehicleBase",
                column: "ElecticSystemId",
                principalTable: "ElectricSystemCatalogue",
                principalColumn: "ElecticSystemId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_UserProfile_UserProfileId",
                table: "VehicleBase",
                column: "UserProfileId",
                principalTable: "UserProfile",
                principalColumn: "UserProfileId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleType_VechileTypeId",
                table: "VehicleBase",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleBrands_VehicleBrandId",
                table: "VehicleBase",
                column: "VehicleBrandId",
                principalTable: "VehicleBrands",
                principalColumn: "VehicleBrandId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleModels_VehicleModelId",
                table: "VehicleBase",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_BreakCatalogue_BrakeId",
                table: "VehicleBase",
                column: "BrakeId",
                principalTable: "BreakCatalogue",
                principalColumn: "BrakeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_MotorCatalogue_MotorId",
                table: "VehicleBase",
                column: "MotorId",
                principalTable: "MotorCatalogue",
                principalColumn: "MotorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_SuspensionCatalogue_SuspensionId",
                table: "VehicleBase",
                column: "SuspensionId",
                principalTable: "SuspensionCatalogue",
                principalColumn: "SuspensionId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_TiresCatalogue_TiresId",
                table: "VehicleBase",
                column: "TiresId",
                principalTable: "TiresCatalogue",
                principalColumn: "TiresId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_VehicleBase_VehicleBaseId1",
                table: "VehicleBase",
                column: "VehicleBaseId1",
                principalTable: "VehicleBase",
                principalColumn: "VehicleBaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBase_WheelCatalogue_WheelId",
                table: "VehicleBase",
                column: "WheelId",
                principalTable: "WheelCatalogue",
                principalColumn: "WheelId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_VehicleBase_VehicleBase_VehicleBaseId1",
                table: "VehicleBase");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBase_WheelCatalogue_WheelId",
                table: "VehicleBase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleBase",
                table: "VehicleBase");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBase_VehicleBaseId1",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "VehicleBase");

            migrationBuilder.DropColumn(
                name: "VehicleBaseId1",
                table: "VehicleBase");

            migrationBuilder.RenameTable(
                name: "VehicleBase",
                newName: "VehicleLand");

            migrationBuilder.RenameColumn(
                name: "VehicleBaseId",
                table: "VehicleLand",
                newName: "VehicleLandId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_WheelId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_WheelId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_TiresId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_TiresId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_SuspensionId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_SuspensionId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_MotorId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_MotorId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_BrakeId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_BrakeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_VehicleModelId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_VehicleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_VehicleBrandId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_VehicleBrandId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_VechileTypeId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_VechileTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_UserProfileId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_ElecticSystemId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_ElecticSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_CombustibleId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_CombustibleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleBase_BodyWorkId",
                table: "VehicleLand",
                newName: "IX_VehicleLand_BodyWorkId");

            migrationBuilder.AlterColumn<long>(
                name: "WheelId",
                table: "VehicleLand",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TiresId",
                table: "VehicleLand",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SuspensionId",
                table: "VehicleLand",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MotorId",
                table: "VehicleLand",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BrakeId",
                table: "VehicleLand",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleLand",
                table: "VehicleLand",
                column: "VehicleLandId");

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
                        name: "FK_VehicleAir_TurbinesCatalogue_TurbinesId",
                        column: x => x.TurbinesId,
                        principalTable: "TurbinesCatalogue",
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
                        name: "FK_VehicleWater_BoatBladesCatalogue_BoatBladesId",
                        column: x => x.BoatBladesId,
                        principalTable: "BoatBladesCatalogue",
                        principalColumn: "BoatBladesId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_BodyWorkCatalogue_BodyWorkId",
                table: "VehicleLand",
                column: "BodyWorkId",
                principalTable: "BodyWorkCatalogue",
                principalColumn: "BodyWorkId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_BreakCatalogue_BrakeId",
                table: "VehicleLand",
                column: "BrakeId",
                principalTable: "BreakCatalogue",
                principalColumn: "BrakeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_CombustibleType_CombustibleId",
                table: "VehicleLand",
                column: "CombustibleId",
                principalTable: "CombustibleType",
                principalColumn: "CombustibleId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_ElectricSystemCatalogue_ElecticSystemId",
                table: "VehicleLand",
                column: "ElecticSystemId",
                principalTable: "ElectricSystemCatalogue",
                principalColumn: "ElecticSystemId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_MotorCatalogue_MotorId",
                table: "VehicleLand",
                column: "MotorId",
                principalTable: "MotorCatalogue",
                principalColumn: "MotorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_SuspensionCatalogue_SuspensionId",
                table: "VehicleLand",
                column: "SuspensionId",
                principalTable: "SuspensionCatalogue",
                principalColumn: "SuspensionId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_TiresCatalogue_TiresId",
                table: "VehicleLand",
                column: "TiresId",
                principalTable: "TiresCatalogue",
                principalColumn: "TiresId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_UserProfile_UserProfileId",
                table: "VehicleLand",
                column: "UserProfileId",
                principalTable: "UserProfile",
                principalColumn: "UserProfileId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_VehicleType_VechileTypeId",
                table: "VehicleLand",
                column: "VechileTypeId",
                principalTable: "VehicleType",
                principalColumn: "VehicleTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_VehicleBrands_VehicleBrandId",
                table: "VehicleLand",
                column: "VehicleBrandId",
                principalTable: "VehicleBrands",
                principalColumn: "VehicleBrandId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_VehicleModels_VehicleModelId",
                table: "VehicleLand",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleLand_WheelCatalogue_WheelId",
                table: "VehicleLand",
                column: "WheelId",
                principalTable: "WheelCatalogue",
                principalColumn: "WheelId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
