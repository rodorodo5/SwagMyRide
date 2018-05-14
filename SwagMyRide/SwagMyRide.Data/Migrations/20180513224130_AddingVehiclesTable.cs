using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingVehiclesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleBrand",
                columns: table => new
                {
                    VehicleBrandId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrand", x => x.VehicleBrandId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    VehicleModelId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleNameModel = table.Column<string>(maxLength: 100, nullable: false),
                    VehicleYearModel = table.Column<short>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.VehicleModelId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BodyWorkCatalogueId = table.Column<long>(nullable: false),
                    BodyWorkId = table.Column<long>(nullable: true),
                    BreakCatalogueId = table.Column<long>(nullable: false),
                    BreakId = table.Column<long>(nullable: true),
                    CombustibleId = table.Column<long>(nullable: false),
                    ElecticSystemId = table.Column<long>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    MotorId = table.Column<long>(nullable: false),
                    SuspensionId = table.Column<long>(nullable: false),
                    TiresId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_BreakCatalogue_BreakId",
                        column: x => x.BreakId,
                        principalTable: "BreakCatalogue",
                        principalColumn: "BreakId",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_SuspensionCatalogue_SuspensionId",
                        column: x => x.SuspensionId,
                        principalTable: "SuspensionCatalogue",
                        principalColumn: "SuspensionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_TiresCatalogue_TiresId",
                        column: x => x.TiresId,
                        principalTable: "TiresCatalogue",
                        principalColumn: "TiresId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleBrand_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrand",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModel_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModel",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vehicles_WheelCatalogue_WheelId",
                        column: x => x.WheelId,
                        principalTable: "WheelCatalogue",
                        principalColumn: "WheelId",
                        onDelete: ReferentialAction.NoAction);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleBrand");

            migrationBuilder.DropTable(
                name: "VehicleModel");
        }
    }
}
