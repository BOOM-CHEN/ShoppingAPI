using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V104 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CarouselId",
                table: "T_Product");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "T_Product",
                newName: "ProductCategoryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCartId",
                table: "T_Product",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "ProductInventory",
                table: "T_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "T_Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "T_Carousel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_T_Product_T_ShoppingCart_ShoppingCartId",
                table: "T_Product",
                column: "ShoppingCartId",
                principalTable: "T_ShoppingCart",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Product_T_ShoppingCart_ShoppingCartId",
                table: "T_Product");

            migrationBuilder.DropColumn(
                name: "ProductInventory",
                table: "T_Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "T_Carousel");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "T_Product",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShoppingCartId",
                table: "T_Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CarouselId",
                table: "T_Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "T_Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_CarouselId",
                table: "T_Product",
                column: "CarouselId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_CategoryId",
                table: "T_Product",
                column: "CategoryId");

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
    }
}
