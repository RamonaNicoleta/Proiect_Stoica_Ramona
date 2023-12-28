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
    [Migration("20231219211955_Location1")]
    partial class Location1
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

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.ToTable("Car");
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

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Car", b =>
                {
                    b.HasOne("Proiect_Stoica_Ramona.Models.Location", "Location")
                        .WithMany("Cars")
                        .HasForeignKey("LocationID");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Proiect_Stoica_Ramona.Models.Location", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}