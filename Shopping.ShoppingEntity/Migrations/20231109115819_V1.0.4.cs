using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V104 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ShoppingCart_T_User_UserId",
                table: "T_ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_T_ShoppingCart_UserId",
                table: "T_ShoppingCart");

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0d5b7d58-6edc-4fa8-9794-5a31e0c370f8"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1216d0f1-32b8-46f8-affa-3c0feb76204f"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1d626b90-02ca-4ddc-b1b0-990d9e3a537a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("20a1f949-791e-4331-8d60-dd97636dc4cc"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("2a1fbded-27e8-4cb6-a87e-acf00e2a6bb7"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("355caab9-bd35-45e6-87b2-4f1c78822cbe"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("41378ce3-07e4-4dd0-85e7-aa0185589073"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("4ef9a13b-4c3f-4410-a765-63b1eaee8f8d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("522b9f8e-576b-444c-859c-64254777b18c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("55c193ba-d4c7-4bd1-aaa6-0be9b6319d55"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5e55c5e8-6bc1-4342-83f5-5c1ede76a695"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("64955edb-150e-4f6d-bb49-38320bf91831"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("789b95ad-a081-4bf1-8d6a-4f1bbfa8bf3b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("88f7bc98-e1be-48a6-be1b-fa05851f1fbb"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("901a83b4-ad38-49fe-bb95-820a1b1c1eeb"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a1e3a7dd-e90b-46b1-bca3-02b180002878"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("ba339c4f-407c-48db-bba9-12f6d03a0ced"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c7120e59-bd31-4534-a5fe-bc2180a40221"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d11bda49-64dd-4149-b165-e6d8b0e4583e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("db714759-a935-4789-b4d2-a97881aab342"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("dfe97f7f-d92a-4845-8b44-b908473f13bf"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("edd55c0b-8aa8-43bf-845e-7e28263ec063"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("fa4544bb-4cd7-43d2-9ca5-2478fd39931a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("fec6ec61-9106-4a6f-bac2-556ccf910cda"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("2a5ea81a-bceb-4151-9725-de51dacde4f9"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("576cf6ba-2460-487a-95cc-3b265e34e87e"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("59acbd94-d04b-44e9-813d-9b92b33c2046"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("64233348-8833-4192-a340-8d4d4eeb051a"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("87f71c42-5189-427e-9137-92a82f7a51cd"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("8b6f89fa-b87f-4452-91a4-6e44a5aae781"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("963b62c4-c0d0-4e83-87e0-90f7a8dd3877"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b082d8d1-d2d7-491e-9290-ac5f7e70e607"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("f8692b94-fdb1-42c1-81ed-1b640f81fc2e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "T_ShoppingCart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("126cd0e7-f7b1-4ba1-83e0-09f42123a52a"), "男装" },
                    { new Guid("18861699-ac27-44bd-aca9-a7eaaf53350c"), "教育书籍" },
                    { new Guid("19ad6597-4346-49d3-b39a-f2dd44490309"), "厨房用具" },
                    { new Guid("1dde4b92-10bf-4226-96fb-2f9716136a29"), "彩妆" },
                    { new Guid("1e95fe11-87fc-43a1-b302-1174b86f4726"), "杂志" },
                    { new Guid("22a53532-6e46-4aab-9fca-c45496cca106"), "装饰品" },
                    { new Guid("41355301-33d1-44b3-a074-af89c5368884"), "饮料" },
                    { new Guid("5c0e9aaa-b5f1-4bf8-a1bd-331c312f1698"), "相机" },
                    { new Guid("6784b5c5-847c-4089-bdba-d9f1956a34e2"), "学习用具" },
                    { new Guid("69395a90-aed0-4558-8f5e-9ded6c8525df"), "童装" },
                    { new Guid("697eb7d8-8741-4db3-bdb9-4f0755271df0"), "运动装备" },
                    { new Guid("76742134-2bf7-48bf-84c5-42550b44e55e"), "调味品" },
                    { new Guid("860466b0-dd43-4d0c-bab4-9aee1b36daf9"), "玩具" },
                    { new Guid("8a25e868-9d05-4970-b4f1-00e38bc98369"), "香水" },
                    { new Guid("8caf3e4e-64d1-4a72-9122-09558eb3d2c7"), "婴儿用品" },
                    { new Guid("98d4cefb-797a-4f35-a1e3-e2184edb2c6d"), "家用电器" },
                    { new Guid("9cd6fa2c-2b08-49e0-aaeb-ad824221fee6"), "女装" },
                    { new Guid("9d5b00f2-bfa9-4c4e-a731-5376e7870296"), "手机" },
                    { new Guid("c2de93e4-9d7b-4eab-88ce-bbdc34a1faa6"), "家具" },
                    { new Guid("d0fcf605-5557-4bac-861c-55a8bd0ce22e"), "小说" },
                    { new Guid("d1de496c-75b9-494d-900f-acce5f707e86"), "护肤品" },
                    { new Guid("d529dd05-2c95-4e4e-96d4-6eddbbca255e"), "生鲜食品" },
                    { new Guid("db652bfd-5b31-4227-a336-d6f78fd34016"), "电脑" },
                    { new Guid("e11f6345-ed1f-4e6b-8893-68ac7a3b471d"), "零食" }
                });

            migrationBuilder.InsertData(
                table: "T_Product",
                columns: new[] { "Id", "ProductCategory", "ProductDate", "ProductDescription", "ProductImage", "ProductInventory", "ProductName", "ProductPrice", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("334c9cf1-79e1-4382-b6fd-f20b38edb9cb"), "电脑", "2023-11-09 19:58:19", "联想系列", null, 255, "联想y7000p", 8555.0, null },
                    { new Guid("4a4659ce-f4b5-4d01-bad6-debe4d9bbfc3"), "小说", "2023-11-09 19:58:19", "江南小说", null, 356, "龙族4", 169.0, null },
                    { new Guid("550f3849-7422-48f2-a3ea-aec8b7234940"), "小说", "2023-11-09 19:58:19", "江南小说", null, 658, "龙族3", 125.0, null },
                    { new Guid("7436c423-ebae-42f9-b54f-a862a6a6e17f"), "手机", "2023-11-09 19:58:19", "小米手机", null, 655, "小米2", 165.0, null },
                    { new Guid("743d208b-256d-434c-9cd2-ee22f7acca1b"), "小说", "2023-11-09 19:58:19", "江南小说", null, 925, "龙族1", 99.0, null },
                    { new Guid("83b32c80-6e60-49f9-9b39-8c9bb724fa34"), "小说", "2023-11-09 19:58:19", "江南小说", null, 854, "龙族2", 109.0, null },
                    { new Guid("973ea450-593c-4749-b906-25e13177917b"), "手机", "2023-11-09 19:58:19", "小米手机", null, 925, "小米1", 250.0, null },
                    { new Guid("d09a3a5d-89d9-4391-9890-4eec73c97d38"), "小说", "2023-11-09 19:58:19", "江南小说", null, 500, "龙族5", 135.0, null },
                    { new Guid("dcf136c7-1e09-412a-a642-180211ecf29d"), "电脑", "2023-11-09 19:58:19", "联想系列", null, 300, "联想7000p", 9555.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("126cd0e7-f7b1-4ba1-83e0-09f42123a52a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("18861699-ac27-44bd-aca9-a7eaaf53350c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("19ad6597-4346-49d3-b39a-f2dd44490309"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1dde4b92-10bf-4226-96fb-2f9716136a29"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("1e95fe11-87fc-43a1-b302-1174b86f4726"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("22a53532-6e46-4aab-9fca-c45496cca106"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("41355301-33d1-44b3-a074-af89c5368884"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5c0e9aaa-b5f1-4bf8-a1bd-331c312f1698"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("6784b5c5-847c-4089-bdba-d9f1956a34e2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("69395a90-aed0-4558-8f5e-9ded6c8525df"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("697eb7d8-8741-4db3-bdb9-4f0755271df0"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("76742134-2bf7-48bf-84c5-42550b44e55e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("860466b0-dd43-4d0c-bab4-9aee1b36daf9"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("8a25e868-9d05-4970-b4f1-00e38bc98369"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("8caf3e4e-64d1-4a72-9122-09558eb3d2c7"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("98d4cefb-797a-4f35-a1e3-e2184edb2c6d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9cd6fa2c-2b08-49e0-aaeb-ad824221fee6"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9d5b00f2-bfa9-4c4e-a731-5376e7870296"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c2de93e4-9d7b-4eab-88ce-bbdc34a1faa6"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d0fcf605-5557-4bac-861c-55a8bd0ce22e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d1de496c-75b9-494d-900f-acce5f707e86"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d529dd05-2c95-4e4e-96d4-6eddbbca255e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("db652bfd-5b31-4227-a336-d6f78fd34016"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e11f6345-ed1f-4e6b-8893-68ac7a3b471d"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("334c9cf1-79e1-4382-b6fd-f20b38edb9cb"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("4a4659ce-f4b5-4d01-bad6-debe4d9bbfc3"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("550f3849-7422-48f2-a3ea-aec8b7234940"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("7436c423-ebae-42f9-b54f-a862a6a6e17f"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("743d208b-256d-434c-9cd2-ee22f7acca1b"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("83b32c80-6e60-49f9-9b39-8c9bb724fa34"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("973ea450-593c-4749-b906-25e13177917b"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("d09a3a5d-89d9-4391-9890-4eec73c97d38"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("dcf136c7-1e09-412a-a642-180211ecf29d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "T_ShoppingCart",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("0d5b7d58-6edc-4fa8-9794-5a31e0c370f8"), "小说" },
                    { new Guid("1216d0f1-32b8-46f8-affa-3c0feb76204f"), "彩妆" },
                    { new Guid("1d626b90-02ca-4ddc-b1b0-990d9e3a537a"), "学习用具" },
                    { new Guid("20a1f949-791e-4331-8d60-dd97636dc4cc"), "厨房用具" },
                    { new Guid("2a1fbded-27e8-4cb6-a87e-acf00e2a6bb7"), "装饰品" },
                    { new Guid("355caab9-bd35-45e6-87b2-4f1c78822cbe"), "教育书籍" },
                    { new Guid("41378ce3-07e4-4dd0-85e7-aa0185589073"), "婴儿用品" },
                    { new Guid("4ef9a13b-4c3f-4410-a765-63b1eaee8f8d"), "杂志" },
                    { new Guid("522b9f8e-576b-444c-859c-64254777b18c"), "电脑" },
                    { new Guid("55c193ba-d4c7-4bd1-aaa6-0be9b6319d55"), "女装" },
                    { new Guid("5e55c5e8-6bc1-4342-83f5-5c1ede76a695"), "护肤品" },
                    { new Guid("64955edb-150e-4f6d-bb49-38320bf91831"), "饮料" },
                    { new Guid("789b95ad-a081-4bf1-8d6a-4f1bbfa8bf3b"), "零食" },
                    { new Guid("88f7bc98-e1be-48a6-be1b-fa05851f1fbb"), "家具" },
                    { new Guid("901a83b4-ad38-49fe-bb95-820a1b1c1eeb"), "手机" },
                    { new Guid("a1e3a7dd-e90b-46b1-bca3-02b180002878"), "调味品" },
                    { new Guid("ba339c4f-407c-48db-bba9-12f6d03a0ced"), "家用电器" },
                    { new Guid("c7120e59-bd31-4534-a5fe-bc2180a40221"), "男装" },
                    { new Guid("d11bda49-64dd-4149-b165-e6d8b0e4583e"), "相机" },
                    { new Guid("db714759-a935-4789-b4d2-a97881aab342"), "运动装备" },
                    { new Guid("dfe97f7f-d92a-4845-8b44-b908473f13bf"), "生鲜食品" },
                    { new Guid("edd55c0b-8aa8-43bf-845e-7e28263ec063"), "香水" },
                    { new Guid("fa4544bb-4cd7-43d2-9ca5-2478fd39931a"), "玩具" },
                    { new Guid("fec6ec61-9106-4a6f-bac2-556ccf910cda"), "童装" }
                });

            migrationBuilder.InsertData(
                table: "T_Product",
                columns: new[] { "Id", "ProductCategory", "ProductDate", "ProductDescription", "ProductImage", "ProductInventory", "ProductName", "ProductPrice", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("2a5ea81a-bceb-4151-9725-de51dacde4f9"), "小说", "2023-11-09 18:09:05", "江南小说", null, 356, "龙族4", 169.0, null },
                    { new Guid("576cf6ba-2460-487a-95cc-3b265e34e87e"), "小说", "2023-11-09 18:09:05", "江南小说", null, 925, "龙族1", 99.0, null },
                    { new Guid("59acbd94-d04b-44e9-813d-9b92b33c2046"), "电脑", "2023-11-09 18:09:05", "联想系列", null, 255, "联想y7000p", 8555.0, null },
                    { new Guid("64233348-8833-4192-a340-8d4d4eeb051a"), "小说", "2023-11-09 18:09:05", "江南小说", null, 854, "龙族2", 109.0, null },
                    { new Guid("87f71c42-5189-427e-9137-92a82f7a51cd"), "小说", "2023-11-09 18:09:05", "江南小说", null, 658, "龙族3", 125.0, null },
                    { new Guid("8b6f89fa-b87f-4452-91a4-6e44a5aae781"), "手机", "2023-11-09 18:09:05", "小米手机", null, 655, "小米2", 165.0, null },
                    { new Guid("963b62c4-c0d0-4e83-87e0-90f7a8dd3877"), "小说", "2023-11-09 18:09:05", "江南小说", null, 500, "龙族5", 135.0, null },
                    { new Guid("b082d8d1-d2d7-491e-9290-ac5f7e70e607"), "手机", "2023-11-09 18:09:05", "小米手机", null, 925, "小米1", 250.0, null },
                    { new Guid("f8692b94-fdb1-42c1-81ed-1b640f81fc2e"), "电脑", "2023-11-09 18:09:05", "联想系列", null, 300, "联想7000p", 9555.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingCart_UserId",
                table: "T_ShoppingCart",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_T_ShoppingCart_T_User_UserId",
                table: "T_ShoppingCart",
                column: "UserId",
                principalTable: "T_User",
                principalColumn: "Id");
        }
    }
}
