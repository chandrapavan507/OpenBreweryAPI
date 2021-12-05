﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenBreweryAPI.DbContexts;

namespace OpenBreweryAPI.Migrations
{
    [DbContext(typeof(OpenBreweryDbContext))]
    [Migration("20211203190646_ChangeEntity")]
    partial class ChangeEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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