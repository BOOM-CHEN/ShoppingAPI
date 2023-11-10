﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopping.ShoppingEntity.Entity;

#nullable disable

namespace Shopping.ShoppingEntity.Migrations
{
    [DbContext(typeof(ShoppingDbContext))]
    [Migration("20231029070917_V1.0.4")]
    partial class V104
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Carousel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("T_Carousel", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("T_Category", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrderDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("OrderTotalPrice")
                        .HasColumnType("real");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShoppingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("T_Order", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Password", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("T_UserPassword", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(1.0);

                    b.Property<int>("ProductInventory")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<Guid?>("ShoppingCartId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("T_Product", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.ShoppingCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("T_ShoppingCart", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RegisterTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRecieveAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("T_User", (string)null);
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Order", b =>
                {
                    b.HasOne("Shopping.ShoppingEntity.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Password", b =>
                {
                    b.HasOne("Shopping.ShoppingEntity.Models.User", "User")
                        .WithOne("Passwords")
                        .HasForeignKey("Shopping.ShoppingEntity.Models.Password", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.Product", b =>
                {
                    b.HasOne("Shopping.ShoppingEntity.Models.ShoppingCart", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.ShoppingCart", b =>
                {
                    b.HasOne("Shopping.ShoppingEntity.Models.User", "User")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("Shopping.ShoppingEntity.Models.ShoppingCart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.ShoppingCart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shopping.ShoppingEntity.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Passwords");

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
