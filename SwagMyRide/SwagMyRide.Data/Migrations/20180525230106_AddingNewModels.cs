using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingNewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MethodProvider",
                columns: table => new
                {
                    MethodProviderId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryDay = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ServiceCost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodProvider", x => x.MethodProviderId);
                });

            migrationBuilder.CreateTable(
                name: "ProvidersComponents",
                columns: table => new
                {
                    ProvidersId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<long>(nullable: false),
                    GuaranteedDays = table.Column<short>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    MethodProviderId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ServiceCost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidersComponents", x => x.ProvidersId);
                    table.ForeignKey(
                        name: "FK_ProvidersComponents_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvidersComponents_MethodProvider_MethodProviderId",
                        column: x => x.MethodProviderId,
                        principalTable: "MethodProvider",
                        principalColumn: "MethodProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProvidersComponents_Brand",
                table: "ProvidersComponents",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidersComponents_MethodProviderId",
                table: "ProvidersComponents",
                column: "MethodProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProvidersComponents");

            migrationBuilder.DropTable(
                name: "MethodProvider");
        }
    }
}
