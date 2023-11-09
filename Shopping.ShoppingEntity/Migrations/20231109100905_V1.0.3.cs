using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V103 : Migration
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
                keyValue: new Guid("05bb47f3-7cac-4d6a-ab90-c770d936d968"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0c6f184a-97d9-4061-a51e-9d9d3325cc8a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0fd17238-9fad-4b4b-bb96-7b5619643e3d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("218445db-d01d-4884-99dd-6ceff726ff44"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("22560735-5af0-4437-aa63-072dbb35e82b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("28697baa-6573-4a54-a8a1-e8901155faed"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("2f845cff-9a3b-421c-ac8d-c9bf3a058035"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("32f0e944-aac3-4d0b-b6dc-fff5a2c930c1"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("3662d026-b8fc-4468-afa5-b4b64be1698e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("4248824d-879c-4464-a495-f8b0591ba882"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("6ec6fe5e-9034-46f2-a284-e6d936633f14"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("7895dec2-f012-4f90-8a87-b0b784c8c14b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9058eed1-7690-4f37-af6e-6c8e190ee245"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("908a47a1-b2f6-492f-b604-a42e12ecc7fd"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a6cb0c79-8240-440d-aeb6-452d431a1531"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b88d2598-9e0a-4098-9f89-e975e56bed38"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("bcfbb528-c357-428a-98f8-9db5e77bb8a5"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c000b9b3-899e-4b0f-8649-8d6681d0a15a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c037325d-dc47-4fdb-8f07-956b728da65e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("cd6e6797-ee25-42c5-84d4-df65c0d2fba1"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e98cde80-a11c-4e9a-b03f-06aec08bada4"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f4c838ea-67fb-4e13-a2a0-044cb15daa6c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f81a6e7e-b485-427f-bd76-6169c3405b7c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("fb9d180e-86d9-49b3-b805-10855a7973fb"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("72591916-1c6c-4c64-b953-b1f9026f32e5"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("80d17f1a-1594-453a-abbb-8c6c42977af2"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("847773cd-f632-4502-897e-c66b68b9856e"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("907438b2-401d-4ffc-93ee-c2da0533d83a"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("96b96da8-a6a6-4c5d-a7f1-3ae2c56b8238"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("a69629cd-9aa9-4347-9681-2eb6e74f1a48"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b4bd90cb-8c8d-4113-abe1-25bb075b24b1"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b4efc0bb-de87-4dae-8810-5a29c4cd48b8"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b829d62e-0e2d-49a9-9c64-7533fa965459"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "T_ShoppingCart",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "ProductQuantity",
                table: "T_ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "ProductQuantity",
                table: "T_ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
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
                    { new Guid("05bb47f3-7cac-4d6a-ab90-c770d936d968"), "家用电器" },
                    { new Guid("0c6f184a-97d9-4061-a51e-9d9d3325cc8a"), "护肤品" },
                    { new Guid("0fd17238-9fad-4b4b-bb96-7b5619643e3d"), "香水" },
                    { new Guid("218445db-d01d-4884-99dd-6ceff726ff44"), "童装" },
                    { new Guid("22560735-5af0-4437-aa63-072dbb35e82b"), "男装" },
                    { new Guid("28697baa-6573-4a54-a8a1-e8901155faed"), "装饰品" },
                    { new Guid("2f845cff-9a3b-421c-ac8d-c9bf3a058035"), "电脑" },
                    { new Guid("32f0e944-aac3-4d0b-b6dc-fff5a2c930c1"), "小说" },
                    { new Guid("3662d026-b8fc-4468-afa5-b4b64be1698e"), "饮料" },
                    { new Guid("4248824d-879c-4464-a495-f8b0591ba882"), "零食" },
                    { new Guid("6ec6fe5e-9034-46f2-a284-e6d936633f14"), "相机" },
                    { new Guid("7895dec2-f012-4f90-8a87-b0b784c8c14b"), "手机" },
                    { new Guid("9058eed1-7690-4f37-af6e-6c8e190ee245"), "彩妆" },
                    { new Guid("908a47a1-b2f6-492f-b604-a42e12ecc7fd"), "厨房用具" },
                    { new Guid("a6cb0c79-8240-440d-aeb6-452d431a1531"), "调味品" },
                    { new Guid("b88d2598-9e0a-4098-9f89-e975e56bed38"), "玩具" },
                    { new Guid("bcfbb528-c357-428a-98f8-9db5e77bb8a5"), "生鲜食品" },
                    { new Guid("c000b9b3-899e-4b0f-8649-8d6681d0a15a"), "学习用具" },
                    { new Guid("c037325d-dc47-4fdb-8f07-956b728da65e"), "女装" },
                    { new Guid("cd6e6797-ee25-42c5-84d4-df65c0d2fba1"), "杂志" },
                    { new Guid("e98cde80-a11c-4e9a-b03f-06aec08bada4"), "运动装备" },
                    { new Guid("f4c838ea-67fb-4e13-a2a0-044cb15daa6c"), "家具" },
                    { new Guid("f81a6e7e-b485-427f-bd76-6169c3405b7c"), "教育书籍" },
                    { new Guid("fb9d180e-86d9-49b3-b805-10855a7973fb"), "婴儿用品" }
                });

            migrationBuilder.InsertData(
                table: "T_Product",
                columns: new[] { "Id", "ProductCategory", "ProductDate", "ProductDescription", "ProductImage", "ProductInventory", "ProductName", "ProductPrice", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("72591916-1c6c-4c64-b953-b1f9026f32e5"), "手机", "2023-11-09 17:31:06", "小米手机", null, 925, "小米1", 250.0, null },
                    { new Guid("80d17f1a-1594-453a-abbb-8c6c42977af2"), "小说", "2023-11-09 17:31:06", "江南小说", null, 925, "龙族1", 99.0, null },
                    { new Guid("847773cd-f632-4502-897e-c66b68b9856e"), "电脑", "2023-11-09 17:31:06", "联想系列", null, 255, "联想y7000p", 8555.0, null },
                    { new Guid("907438b2-401d-4ffc-93ee-c2da0533d83a"), "手机", "2023-11-09 17:31:06", "小米手机", null, 655, "小米2", 165.0, null },
                    { new Guid("96b96da8-a6a6-4c5d-a7f1-3ae2c56b8238"), "小说", "2023-11-09 17:31:06", "江南小说", null, 356, "龙族4", 169.0, null },
                    { new Guid("a69629cd-9aa9-4347-9681-2eb6e74f1a48"), "电脑", "2023-11-09 17:31:06", "联想系列", null, 300, "联想7000p", 9555.0, null },
                    { new Guid("b4bd90cb-8c8d-4113-abe1-25bb075b24b1"), "小说", "2023-11-09 17:31:06", "江南小说", null, 854, "龙族2", 109.0, null },
                    { new Guid("b4efc0bb-de87-4dae-8810-5a29c4cd48b8"), "小说", "2023-11-09 17:31:06", "江南小说", null, 500, "龙族5", 135.0, null },
                    { new Guid("b829d62e-0e2d-49a9-9c64-7533fa965459"), "小说", "2023-11-09 17:31:06", "江南小说", null, 658, "龙族3", 125.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingCart_UserId",
                table: "T_ShoppingCart",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ShoppingCart_T_User_UserId",
                table: "T_ShoppingCart",
                column: "UserId",
                principalTable: "T_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
