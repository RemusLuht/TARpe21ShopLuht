﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARpe21ShopLuht.Data;

#nullable disable

namespace TARpe21ShopLuht.Data.Migrations
{
    [DbContext(typeof(TARpe21ShopLuhtContext))]
    [Migration("20231110074016_realestate")]
    partial class realestate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.FileToApi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExistingFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RealEstateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RealEstateId");

                    b.ToTable("FilesToApi");
                });

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.FileToDatabase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpaceshipId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FilesToDatabase");
                });

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.RealEstate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("int");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("int");

                    b.Property<DateTime>("BuildDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DoesHaveParkingSpace")
                        .HasColumnType("bit");

                    b.Property<bool>("DoesHavePowerGridConnection")
                        .HasColumnType("bit");

                    b.Property<bool>("DoesHaveWaterGridConnection")
                        .HasColumnType("bit");

                    b.Property<int?>("EstateFloor")
                        .HasColumnType("int");

                    b.Property<int>("FaxNumber")
                        .HasColumnType("int");

                    b.Property<int>("FloorCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsPropertyNewDevelopment")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPropertySold")
                        .HasColumnType("bit");

                    b.Property<string>("ListingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.Property<int>("SquareMeters")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RealEstates");
                });

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.Spaceship.Spaceship", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BuiltAtDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CargoWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CrewCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnginePower")
                        .HasColumnType("int");

                    b.Property<int>("FuelConsumptionPerDay")
                        .HasColumnType("int");

                    b.Property<int>("FullTripsCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsSpaceshipPreviouslyOwned")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastMaintenance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaidenLaunch")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaintenanceCount")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxSpeedInVaccuum")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassengerCount")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spaceships");
                });

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.FileToApi", b =>
                {
                    b.HasOne("TARpe21ShopLuht.Core.Domain.RealEstate", null)
                        .WithMany("FilesToApi")
                        .HasForeignKey("RealEstateId");
                });

            modelBuilder.Entity("TARpe21ShopLuht.Core.Domain.RealEstate", b =>
                {
                    b.Navigation("FilesToApi");
                });
#pragma warning restore 612, 618
        }
    }
}
