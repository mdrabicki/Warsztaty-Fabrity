using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNotesWall.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems");

            migrationBuilder.AlterColumn<int>(
                name: "WallId",
                table: "UserWallItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "UserWallItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "WallId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems");

            migrationBuilder.AlterColumn<int>(
                name: "WallId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "WallId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
