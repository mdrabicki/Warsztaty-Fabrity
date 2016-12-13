using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyNotesWall.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Walls");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WallID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemId",
                table: "Walls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserWallItems",
                columns: table => new
                {
                    UserWallItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    WallId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWallItems", x => x.UserWallItemId);
                    table.ForeignKey(
                        name: "FK_UserWallItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWallItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWallItems_Walls_WallId",
                        column: x => x.WallId,
                        principalTable: "Walls",
                        principalColumn: "WallId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walls_UserWallItemId",
                table: "Walls",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserWallItemId",
                table: "Items",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserWallItemId",
                table: "AspNetUsers",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWallItems_ItemId",
                table: "UserWallItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWallItems_UserId",
                table: "UserWallItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWallItems_WallId",
                table: "UserWallItems",
                column: "WallId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserWallItems_UserWallItemId",
                table: "AspNetUsers",
                column: "UserWallItemId",
                principalTable: "UserWallItems",
                principalColumn: "UserWallItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UserWallItems_UserWallItemId",
                table: "Items",
                column: "UserWallItemId",
                principalTable: "UserWallItems",
                principalColumn: "UserWallItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemId",
                table: "Walls",
                column: "UserWallItemId",
                principalTable: "UserWallItems",
                principalColumn: "UserWallItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserWallItems_UserWallItemId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_UserWallItems_UserWallItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemId",
                table: "Walls");

            migrationBuilder.DropTable(
                name: "UserWallItems");

            migrationBuilder.DropIndex(
                name: "IX_Walls_UserWallItemId",
                table: "Walls");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserWallItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserWallItemId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserWallItemId",
                table: "Walls");

            migrationBuilder.DropColumn(
                name: "UserWallItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserWallItemId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Walls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WallID",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }
    }
}
