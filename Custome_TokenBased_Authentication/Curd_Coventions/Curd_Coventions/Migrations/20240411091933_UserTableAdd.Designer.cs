﻿// <auto-generated />
using Curd_Coventions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curd_Coventions.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240411091933_UserTableAdd")]
    partial class UserTableAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Curd_Coventions.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<string>("MfgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            MfgName = "Intex",
                            Price = 410m,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            ProductID = 2L,
                            MfgName = "Logitech",
                            Price = 410m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductID = 3L,
                            MfgName = "LG",
                            Price = 4100m,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            ProductID = 4L,
                            MfgName = "Renolds",
                            Price = 50m,
                            ProductName = "Marker"
                        });
                });

            modelBuilder.Entity("Curd_Coventions.Models.Token", b =>
                {
                    b.Property<long>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TokenId"));

                    b.Property<string>("TokenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("TokenId");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Curd_Coventions.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserId"));

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            EmailId = "priya@gmail.com",
                            FirstName = "Priyanka",
                            LastName = "Chaure",
                            Password = "123"
                        },
                        new
                        {
                            UserId = 2L,
                            EmailId = "sweety@gmail.com",
                            FirstName = "Sweety",
                            LastName = "Chaure",
                            Password = "123"
                        });
                });

            modelBuilder.Entity("Curd_Coventions.Models.Token", b =>
                {
                    b.HasOne("Curd_Coventions.Models.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Curd_Coventions.Models.User", b =>
                {
                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
