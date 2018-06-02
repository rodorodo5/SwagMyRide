using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SwagMyRide.Data.Migrations
{
    public partial class AddingComponenTypeAndGlobalHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalHistory",
                columns: table => new
                {
                    GlobalHisoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastBuyDateTime = table.Column<DateTime>(nullable: false),
                    OrderListId = table.Column<long>(nullable: false),
                    UserProfileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalHistory", x => x.GlobalHisoryId);
                    table.ForeignKey(
                        name: "FK_GlobalHistory_OrderList_OrderListId",
                        column: x => x.OrderListId,
                        principalTable: "OrderList",
                        principalColumn: "OrderListId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GlobalHistory_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalHistory_OrderListId",
                table: "GlobalHistory",
                column: "OrderListId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalHistory_UserProfileId",
                table: "GlobalHistory",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalHistory");
        }
    }
}
