﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("DomainLayer.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("created_date");

                    b.Property<string>("CustomerName")
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("Customer_Name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("modified_date");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("payment_type");

                    b.Property<string>("PurchasesProduct")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("purchased_product");

                    b.HasKey("Id")
                        .HasName("pk_customerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DomainLayer.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)")
                        .HasColumnName("Product_Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnName("Price");

                    b.HasKey("Id")
                        .HasName("pk_product");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
