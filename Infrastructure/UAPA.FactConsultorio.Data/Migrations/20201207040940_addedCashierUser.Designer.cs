﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UAPA.FactConsultorio.Data;

namespace UAPA.FactConsultorio.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201207040940_addedCashierUser")]
    partial class addedCashierUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Enabled = true,
                            Locked = false,
                            Name = "SYSADMIN",
                            Password = "????n????:b??????]Z?????:?l?",
                            UserName = "SYSADMIN",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 2,
                            Enabled = true,
                            Locked = false,
                            Name = "CASHIER",
                            Password = "????n????:b??????]Z?????:?l?",
                            UserName = "CAJERO",
                            UserRole = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
