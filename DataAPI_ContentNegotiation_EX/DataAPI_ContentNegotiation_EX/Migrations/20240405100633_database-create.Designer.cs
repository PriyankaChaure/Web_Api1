﻿// <auto-generated />
using DataAPI_ContentNegotiation_EX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAPI_ContentNegotiation_EX.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240405100633_database-create")]
    partial class databasecreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAPI_ContentNegotiation_EX.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductId"));

                    b.Property<string>("MfgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1L,
                            MfgName = "Shine",
                            Price = 5m,
                            ProductName = "Pen"
                        },
                        new
                        {
                            ProductId = 2L,
                            MfgName = "Nataraj",
                            Price = 5m,
                            ProductName = "Pencil"
                        },
                        new
                        {
                            ProductId = 3L,
                            MfgName = "Scala",
                            Price = 5m,
                            ProductName = "Sacle"
                        },
                        new
                        {
                            ProductId = 4L,
                            MfgName = "Shine",
                            Price = 5m,
                            ProductName = "Erasor"
                        },
                        new
                        {
                            ProductId = 5L,
                            MfgName = "Deft",
                            Price = 5m,
                            ProductName = "Shopner"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
