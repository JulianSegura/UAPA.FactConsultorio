﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UAPA.FactConsultorio.Data;

namespace UAPA.FactConsultorio.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201209035004_AddedReceiptClasses2")]
    partial class AddedReceiptClasses2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BithDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReceiptId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CashierId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ReceiptTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CashierId");

                    b.HasIndex("PatientId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.ReceiptLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ReceiptLines");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

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
                            UserRole = 2
                        });
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Payment", b =>
                {
                    b.HasOne("UAPA.FactConsultorio.Domain.Entities.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.Receipt", b =>
                {
                    b.HasOne("UAPA.FactConsultorio.Domain.Entities.User", "Cashier")
                        .WithMany()
                        .HasForeignKey("CashierId");

                    b.HasOne("UAPA.FactConsultorio.Domain.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("UAPA.FactConsultorio.Domain.Entities.ReceiptLine", b =>
                {
                    b.HasOne("UAPA.FactConsultorio.Domain.Entities.Receipt", "Receipt")
                        .WithMany("Details")
                        .HasForeignKey("ReceiptId");

                    b.HasOne("UAPA.FactConsultorio.Domain.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");
                });
#pragma warning restore 612, 618
        }
    }
}
