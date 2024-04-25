﻿// <auto-generated />
using System;
using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    [DbContext(typeof(Appdbcontext))]
    partial class AppdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagementSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<int>("Creditpoints")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("longtext");

                    b.Property<long>("MobileNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Retailerid")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.HasIndex("Retailerid");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("BillId")
                        .HasColumnType("longtext");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("RetailerID")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductsId");

                    b.HasIndex("RetailerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<int>("BuyingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("ProductImage")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<int>("Productcode")
                        .HasColumnType("int");

                    b.Property<int>("Retailerid")
                        .HasColumnType("int");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductsId");

                    b.HasIndex("Retailerid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<string>("BillId")
                        .HasColumnType("longtext");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Purchasestatus")
                        .HasColumnType("longtext");

                    b.Property<int>("Retailerid")
                        .HasColumnType("int");

                    b.Property<int>("SuperProductId")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId");

                    b.HasIndex("Retailerid");

                    b.HasIndex("SuperProductId");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Retailer", b =>
                {
                    b.Property<int>("Retailerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Retailerid"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GstNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Mobilenumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasKey("Retailerid");

                    b.ToTable("Retailer");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SuperProduct", b =>
                {
                    b.Property<int>("SuperProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SuperProductId"));

                    b.Property<int>("BuyingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("ProductImage")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<int>("Productcode")
                        .HasColumnType("int");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("SuperProductId");

                    b.ToTable("SuperProduct");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Customer", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Retailer", "Retailer")
                        .WithMany()
                        .HasForeignKey("Retailerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Retailer");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Order", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Models.Retailer", "Retailer")
                        .WithMany()
                        .HasForeignKey("RetailerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Products");

                    b.Navigation("Retailer");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Products", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Retailer", "Retailer")
                        .WithMany()
                        .HasForeignKey("Retailerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Retailer");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Purchase", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Retailer", "Retailer")
                        .WithMany()
                        .HasForeignKey("Retailerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Models.SuperProduct", "SuperProduct")
                        .WithMany()
                        .HasForeignKey("SuperProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Retailer");

                    b.Navigation("SuperProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
