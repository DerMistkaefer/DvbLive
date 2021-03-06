﻿// <auto-generated />
using DerMistkaefer.DvbLive.Backend.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DerMistkaefer.DvbLive.Backend.Migrations
{
    [DbContext(typeof(DvbDbContext))]
    partial class DvbDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DerMistkaefer.DvbLive.Backend.Database.Entity.StopPoints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("StopPointName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TriasIdStopPoint")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StopPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
