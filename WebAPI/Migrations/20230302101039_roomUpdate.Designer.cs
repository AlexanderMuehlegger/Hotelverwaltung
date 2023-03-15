﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models.DB;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230302101039_roomUpdate")]
    partial class roomUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hotel.Room", b =>
                {
                    b.Property<int>("number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("available")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hasBalcony")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hasKitchen")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("hasTerrace")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("nightPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("numBed")
                        .HasColumnType("int");

                    b.HasKey("number");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
