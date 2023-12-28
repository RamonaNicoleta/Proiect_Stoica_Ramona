﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Stoica_Ramona.Data;

#nullable disable

namespace Proiect_Stoica_Ramona.Migrations
{
    [DbContext(typeof(Proiect_Stoica_RamonaContext))]
    [Migration("20231220081704_Member")]
    partial class Member
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AvailabeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.EngineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Assigned")
                        .HasColumnType("bit");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("EngineType");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Rent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CarID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CarID")
                        .IsUnique()
                        .HasFilter("[CarID] IS NOT NULL");

                    b.HasIndex("ClientID");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Car", b =>
                {
                    b.HasOne("Proiect_Stoica_Ramona.Models.Location", "Location")
                        .WithMany("Cars")
                        .HasForeignKey("LocationID");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.EngineType", b =>
                {
                    b.HasOne("Proiect_Stoica_Ramona.Models.Car", null)
                        .WithMany("EngineTypes")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Rent", b =>
                {
                    b.HasOne("Proiect_Stoica_Ramona.Models.Car", "Car")
                        .WithOne("Rent")
                        .HasForeignKey("Proiect_Stoica_Ramona.Models.Rent", "CarID");

                    b.HasOne("Proiect_Stoica_Ramona.Models.Client", "Client")
                        .WithMany("Rents")
                        .HasForeignKey("ClientID");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Car", b =>
                {
                    b.Navigation("EngineTypes");

                    b.Navigation("Rent");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Client", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Location", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}