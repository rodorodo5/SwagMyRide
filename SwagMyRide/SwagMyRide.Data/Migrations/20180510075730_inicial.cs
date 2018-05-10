using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandCatalogue",
                columns: table => new
                {
                    BrandId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Logo = table.Column<string>(maxLength: 90, nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandCatalogue", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CitiyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CitiyId);
                });

            migrationBuilder.CreateTable(
                name: "CombustibleType",
                columns: table => new
                {
                    CombustibleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombustibleType", x => x.CombustibleId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "BodyWorkCatalogue",
                columns: table => new
                {
                    BodyWorkId = table.Column<long>(nullable: false)
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
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyWorkCatalogue", x => x.BodyWorkId);
                    table.ForeignKey(
                        name: "FK_BodyWorkCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodyWorkCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreakCatalogue",
                columns: table => new
                {
                    BreakId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Pressure = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakCatalogue", x => x.BreakId);
                    table.ForeignKey(
                        name: "FK_BreakCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreakCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricSystemCatalogue",
                columns: table => new
                {
                    ElecticSystemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Volts = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricSystemCatalogue", x => x.ElecticSystemId);
                    table.ForeignKey(
                        name: "FK_ElectricSystemCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricSystemCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorCatalogue",
                columns: table => new
                {
                    MotorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    CombustibleId = table.Column<long>(nullable: false),
                    Cylinders = table.Column<short>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    HorsePower = table.Column<short>(nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorCatalogue", x => x.MotorId);
                    table.ForeignKey(
                        name: "FK_MotorCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorCatalogue_CombustibleType_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "CombustibleType",
                        principalColumn: "CombustibleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Country = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_Country_Country",
                        column: x => x.Country,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuspensionCatalogue",
                columns: table => new
                {
                    SuspensionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuspensionCatalogue", x => x.SuspensionId);
                    table.ForeignKey(
                        name: "FK_SuspensionCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuspensionCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiresCatalogue",
                columns: table => new
                {
                    TiresId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Size = table.Column<short>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiresCatalogue", x => x.TiresId);
                    table.ForeignKey(
                        name: "FK_TiresCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TiresCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<short>(nullable: false),
                    Brithday = table.Column<DateTime>(nullable: false),
                    Country = table.Column<long>(nullable: false),
                    Email = table.Column<string>(maxLength: 2147483647, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    UserLastName = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfile_Country_Country",
                        column: x => x.Country,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WheelCatalogue",
                columns: table => new
                {
                    WheelId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Brand = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Manufactured = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 90, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Size = table.Column<short>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelCatalogue", x => x.WheelId);
                    table.ForeignKey(
                        name: "FK_WheelCatalogue_BrandCatalogue_Brand",
                        column: x => x.Brand,
                        principalTable: "BrandCatalogue",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WheelCatalogue_Country_Manufactured",
                        column: x => x.Manufactured,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyWorkCatalogue_Brand",
                table: "BodyWorkCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_BodyWorkCatalogue_Manufactured",
                table: "BodyWorkCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_BreakCatalogue_Brand",
                table: "BreakCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_BreakCatalogue_Manufactured",
                table: "BreakCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricSystemCatalogue_Brand",
                table: "ElectricSystemCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricSystemCatalogue_Manufactured",
                table: "ElectricSystemCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_Brand",
                table: "MotorCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_CombustibleId",
                table: "MotorCatalogue",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorCatalogue_Manufactured",
                table: "MotorCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_State_Country",
                table: "State",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_SuspensionCatalogue_Brand",
                table: "SuspensionCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_SuspensionCatalogue_Manufactured",
                table: "SuspensionCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_TiresCatalogue_Brand",
                table: "TiresCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_TiresCatalogue_Manufactured",
                table: "TiresCatalogue",
                column: "Manufactured");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_Country",
                table: "UserProfile",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_WheelCatalogue_Brand",
                table: "WheelCatalogue",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_WheelCatalogue_Manufactured",
                table: "WheelCatalogue",
                column: "Manufactured");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyWorkCatalogue");

            migrationBuilder.DropTable(
                name: "BreakCatalogue");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "ElectricSystemCatalogue");

            migrationBuilder.DropTable(
                name: "MotorCatalogue");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "SuspensionCatalogue");

            migrationBuilder.DropTable(
                name: "TiresCatalogue");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "WheelCatalogue");

            migrationBuilder.DropTable(
                name: "CombustibleType");

            migrationBuilder.DropTable(
                name: "BrandCatalogue");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
