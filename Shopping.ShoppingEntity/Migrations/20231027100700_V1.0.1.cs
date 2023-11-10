using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Carousel_T_Product_ProductId",
                table: "T_Carousel");

            migrationBuilder.DropForeignKey(
                name: "FK_T_ShoppingCart_T_Product_ProductId",
                table: "T_ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_T_ShoppingCart_ProductId",
                table: "T_ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_T_Order_UserId",
                table: "T_Order");

            migrationBuilder.DropIndex(
                name: "IX_T_Carousel_ProductId",
                table: "T_Carousel");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "T_ShoppingCart");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "T_Carousel");

            migrationBuilder.AddColumn<Guid>(
                name: "CarouselId",
                table: "T_Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShoppingCartId",
                table: "T_Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_CarouselId",
                table: "T_Product",
                column: "CarouselId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_CategoryId",
                table: "T_Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_ShoppingCartId",
                table: "T_Product",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Order_UserId",
                table: "T_Order",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Product_T_Carousel_CarouselId",
                table: "T_Product",
                column: "CarouselId",
                principalTable: "T_Carousel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Product_T_Category_CategoryId",
                table: "T_Product",
                column: "CategoryId",
                principalTable: "T_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Product_T_ShoppingCart_ShoppingCartId",
                table: "T_Product",
                column: "ShoppingCartId",
                principalTable: "T_ShoppingCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Product_T_Carousel_CarouselId",
                table: "T_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Product_T_Category_CategoryId",
                table: "T_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Product_T_ShoppingCart_ShoppingCartId",
                table: "T_Product");

            migrationBuilder.DropIndex(
                name: "IX_T_Product_CarouselId",
                table: "T_Product");

            migrationBuilder.DropIndex(
                name: "IX_T_Product_CategoryId",
                table: "T_Product");

            migrationBuilder.DropIndex(
                name: "IX_T_Product_ShoppingCartId",
                table: "T_Product");

            migrationBuilder.DropIndex(
                name: "IX_T_Order_UserId",
                table: "T_Order");

            migrationBuilder.DropColumn(
                name: "CarouselId",
                table: "T_Product");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "T_Product");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "T_ShoppingCart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "T_Carousel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingCart_ProductId",
                table: "T_ShoppingCart",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Order_UserId",
                table: "T_Order",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Carousel_ProductId",
                table: "T_Carousel",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Carousel_T_Product_ProductId",
                table: "T_Carousel",
                column: "ProductId",
                principalTable: "T_Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ShoppingCart_T_Product_ProductId",
                table: "T_ShoppingCart",
                column: "ProductId",
                principalTable: "T_Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
