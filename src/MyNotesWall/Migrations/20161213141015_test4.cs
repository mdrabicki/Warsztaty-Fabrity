using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyNotesWall.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserWallItems_UserWallItemId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_UserWallItems_UserWallItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_AspNetUsers_UserId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemId",
                table: "Walls");

            migrationBuilder.DropIndex(
                name: "IX_Walls_UserWallItemId",
                table: "Walls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWallItems",
                table: "UserWallItems");

            migrationBuilder.DropIndex(
                name: "IX_UserWallItems_WallId",
                table: "UserWallItems");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserWallItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserWallItemId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserWallItemId",
                table: "Walls",
                newName: "UserWallItemWallId");

            migrationBuilder.RenameColumn(
                name: "UserWallItemId",
                table: "Items",
                newName: "UserWallItemWallId");

            migrationBuilder.RenameColumn(
                name: "UserWallItemId",
                table: "AspNetUsers",
                newName: "UserWallItemWallId");

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemItemId",
                table: "Walls",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserWallItemUserId",
                table: "Walls",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WallId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserWallItemId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemItemId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserWallItemUserId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWallItemItemId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserWallItemUserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWallItems",
                table: "UserWallItems",
                columns: new[] { "WallId", "ItemId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Walls_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Walls",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Items",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "AspNetUsers",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "AspNetUsers",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" },
                principalTable: "UserWallItems",
                principalColumns: new[] { "WallId", "ItemId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Items",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" },
                principalTable: "UserWallItems",
                principalColumns: new[] { "WallId", "ItemId", "UserId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_AspNetUsers_UserId",
                table: "UserWallItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "WallId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Walls",
                columns: new[] { "UserWallItemWallId", "UserWallItemItemId", "UserWallItemUserId" },
                principalTable: "UserWallItems",
                principalColumns: new[] { "WallId", "ItemId", "UserId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_AspNetUsers_UserId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Walls");

            migrationBuilder.DropIndex(
                name: "IX_Walls_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Walls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWallItems",
                table: "UserWallItems");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserWallItemWallId_UserWallItemItemId_UserWallItemUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserWallItemItemId",
                table: "Walls");

            migrationBuilder.DropColumn(
                name: "UserWallItemUserId",
                table: "Walls");

            migrationBuilder.DropColumn(
                name: "UserWallItemItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserWallItemUserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserWallItemItemId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserWallItemUserId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserWallItemWallId",
                table: "Walls",
                newName: "UserWallItemId");

            migrationBuilder.RenameColumn(
                name: "UserWallItemWallId",
                table: "Items",
                newName: "UserWallItemId");

            migrationBuilder.RenameColumn(
                name: "UserWallItemWallId",
                table: "AspNetUsers",
                newName: "UserWallItemId");

            migrationBuilder.AlterColumn<int>(
                name: "UserWallItemId",
                table: "UserWallItems",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserWallItems",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "UserWallItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "WallId",
                table: "UserWallItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWallItems",
                table: "UserWallItems",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Walls_UserWallItemId",
                table: "Walls",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWallItems_WallId",
                table: "UserWallItems",
                column: "WallId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserWallItemId",
                table: "Items",
                column: "UserWallItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserWallItemId",
                table: "AspNetUsers",
                column: "UserWallItemId");

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
                name: "FK_UserWallItems_Items_ItemId",
                table: "UserWallItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_AspNetUsers_UserId",
                table: "UserWallItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWallItems_Walls_WallId",
                table: "UserWallItems",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "WallId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Walls_UserWallItems_UserWallItemId",
                table: "Walls",
                column: "UserWallItemId",
                principalTable: "UserWallItems",
                principalColumn: "UserWallItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
