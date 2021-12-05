﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenBreweryAPI.DbContexts;

namespace OpenBreweryAPI.Migrations
{
    [DbContext(typeof(OpenBreweryDbContext))]
    partial class OpenBreweryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OpenBreweryAPI.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            Address2 = "",
                            Address3 = "",
                            City = "Knox",
                            Latitude = -86.627954000000003,
                            Longitude = 41.289715000000001,
                            State = "Indiana",
                            Street = "400 Brown Cir",
                            ZipCode = "46534"
                        },
                        new
                        {
                            AddressId = 2,
                            Address2 = "",
                            Address3 = "",
                            City = "Bend",
                            Latitude = -121.2809536,
                            Longitude = 44.0912109,
                            State = "Oregon",
                            Street = "62950 NE 18th St",
                            ZipCode = "97701-9847"
                        },
                        new
                        {
                            AddressId = 3,
                            Address2 = "",
                            Address3 = "",
                            City = "Boise",
                            Latitude = -116.202929,
                            Longitude = 43.618516,
                            State = "Idaho",
                            Street = "826 W Bannock St",
                            ZipCode = "83702-5857"
                        });
                });

            modelBuilder.Entity("OpenBreweryAPI.Entities.Brewery", b =>
                {
                    b.Property<int>("BreweryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("BreweryCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebSiteURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BreweryId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("BreweryCategoryId");

                    b.ToTable("Brewerys");

                    b.HasData(
                        new
                        {
                            BreweryId = 1,
                            AddressId = 1,
                            BreweryCategoryId = 1,
                            CreatedAt = new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(6853),
                            Name = "10-barrel-brewing-co-bend-1",
                            Phone = "5415851007",
                            WebSiteURL = "http://www.10barrel.com"
                        },
                        new
                        {
                            BreweryId = 2,
                            AddressId = 2,
                            BreweryCategoryId = 2,
                            CreatedAt = new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(7319),
                            Name = "10 Torr Distilling and Brewing",
                            Phone = "5415851007",
                            WebSiteURL = "http://www.10barrel.com"
                        },
                        new
                        {
                            BreweryId = 3,
                            AddressId = 3,
                            BreweryCategoryId = 3,
                            CreatedAt = new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(7322),
                            Name = "10 Barrel Brewing Co - Bend Pub",
                            Phone = "5415851007",
                            WebSiteURL = "http://www.10barrel.com"
                        });
                });

            modelBuilder.Entity("OpenBreweryAPI.Entities.BreweryCategory", b =>
                {
                    b.Property<int>("BreweryCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BreweryCategoryId");

                    b.ToTable("BreweryCategorys");

                    b.HasData(
                        new
                        {
                            BreweryCategoryId = 1,
                            Type = "medium"
                        },
                        new
                        {
                            BreweryCategoryId = 2,
                            Type = "micro"
                        },
                        new
                        {
                            BreweryCategoryId = 3,
                            Type = "large"
                        });
                });

            modelBuilder.Entity("OpenBreweryAPI.Entities.Brewery", b =>
                {
                    b.HasOne("OpenBreweryAPI.Entities.Address", "Address")
                        .WithOne("Brewery")
                        .HasForeignKey("OpenBreweryAPI.Entities.Brewery", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenBreweryAPI.Entities.BreweryCategory", "BreweryCategory")
                        .WithMany("Brewerys")
                        .HasForeignKey("BreweryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("BreweryCategory");
                });

            modelBuilder.Entity("OpenBreweryAPI.Entities.Address", b =>
                {
                    b.Navigation("Brewery");
                });

            modelBuilder.Entity("OpenBreweryAPI.Entities.BreweryCategory", b =>
                {
                    b.Navigation("Brewerys");
                });
#pragma warning restore 612, 618
        }
    }
}
