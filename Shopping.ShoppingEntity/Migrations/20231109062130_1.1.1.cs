using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class _111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0386882a-9987-4eb5-abf2-fc730cf42fa8"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0cc084f2-3808-4835-9f11-f7f5870c7c56"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1838dafb-6842-43c6-8b80-4a42e488736e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1ff8e0a5-a348-4229-8274-1e63ebe457e2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("26d16ddc-2c77-4824-b1d0-527dc2416612"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("2eb8d3f5-4f1a-4720-990f-54d0e3f30949"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("368caa20-b894-4972-9e30-22351a928a9a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("36dd7faa-5072-4a16-af17-061f73ebb75e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("51202591-f568-4f43-a053-47cc29607ea0"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5542c5d3-70d6-42cb-9d0c-a5db8590112d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("56c60d50-090f-46d0-abbf-ad823a4c7631"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("57f6578b-ce7a-4093-a448-06b5374de0ae"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("59b32283-ba8d-455c-a6d4-92bfc5dcbe7c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("72309e08-8968-4909-92e4-8ddcd684ee1d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("82fb84de-e210-4b0d-83b5-54b8ed7fe41f"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("877b2494-6ac3-4155-8b01-3775254eda49"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9df6cc40-30a7-462f-98bf-999786c0bc69"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b2fe8d00-3856-4730-81fc-625105265bbe"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b6697a1f-7564-47a0-9665-3a0d0bf10f97"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d0ee7d8f-4aa1-4e07-9981-2e547805ba0c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("df37cbbc-b42e-474d-ab8d-45dd51550194"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e0b6d344-34d3-4e3b-ac7f-034a1cf11e83"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("ea46f6ab-2331-40c8-ab16-4f35b5072c8a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f6fd420c-0e61-4345-bceb-07bfb99be228"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "T_ShoppingCart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ProductCategory",
                table: "T_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "T_ShoppingCart");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCategory",
                table: "T_Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("0386882a-9987-4eb5-abf2-fc730cf42fa8"), "生鲜食品" },
                    { new Guid("0cc084f2-3808-4835-9f11-f7f5870c7c56"), "饮料" },
                    { new Guid("1838dafb-6842-43c6-8b80-4a42e488736e"), "教育书籍" },
                    { new Guid("1ff8e0a5-a348-4229-8274-1e63ebe457e2"), "相机" },
                    { new Guid("26d16ddc-2c77-4824-b1d0-527dc2416612"), "装饰品" },
                    { new Guid("2eb8d3f5-4f1a-4720-990f-54d0e3f30949"), "杂志" },
                    { new Guid("368caa20-b894-4972-9e30-22351a928a9a"), "男装" },
                    { new Guid("36dd7faa-5072-4a16-af17-061f73ebb75e"), "小说" },
                    { new Guid("51202591-f568-4f43-a053-47cc29607ea0"), "厨房用具" },
                    { new Guid("5542c5d3-70d6-42cb-9d0c-a5db8590112d"), "运动装备" },
                    { new Guid("56c60d50-090f-46d0-abbf-ad823a4c7631"), "护肤品" },
                    { new Guid("57f6578b-ce7a-4093-a448-06b5374de0ae"), "电脑" },
                    { new Guid("59b32283-ba8d-455c-a6d4-92bfc5dcbe7c"), "手机" },
                    { new Guid("72309e08-8968-4909-92e4-8ddcd684ee1d"), "女装" },
                    { new Guid("82fb84de-e210-4b0d-83b5-54b8ed7fe41f"), "彩妆" },
                    { new Guid("877b2494-6ac3-4155-8b01-3775254eda49"), "家具" },
                    { new Guid("9df6cc40-30a7-462f-98bf-999786c0bc69"), "童装" },
                    { new Guid("b2fe8d00-3856-4730-81fc-625105265bbe"), "香水" },
                    { new Guid("b6697a1f-7564-47a0-9665-3a0d0bf10f97"), "调味品" },
                    { new Guid("d0ee7d8f-4aa1-4e07-9981-2e547805ba0c"), "学习用具" },
                    { new Guid("df37cbbc-b42e-474d-ab8d-45dd51550194"), "玩具" },
                    { new Guid("e0b6d344-34d3-4e3b-ac7f-034a1cf11e83"), "零食" },
                    { new Guid("ea46f6ab-2331-40c8-ab16-4f35b5072c8a"), "家用电器" },
                    { new Guid("f6fd420c-0e61-4345-bceb-07bfb99be228"), "婴儿用品" }
                });
        }
    }
}
