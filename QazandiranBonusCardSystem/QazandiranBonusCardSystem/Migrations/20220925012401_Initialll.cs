using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QazandiranBonusCardSystem.Migrations
{
    public partial class Initialll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets");

            migrationBuilder.AddColumn<Guid>(
                name: "BasketId1",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "Baskets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BasketId1",
                table: "Products",
                column: "BasketId1");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId1",
                table: "Baskets",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserId1",
                table: "Baskets",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Baskets_BasketId1",
                table: "Products",
                column: "BasketId1",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Baskets_Id",
                table: "Users",
                column: "Id",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserId1",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Baskets_BasketId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Baskets_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_BasketId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserId1",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "BasketId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Baskets");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserId",
                table: "Baskets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
