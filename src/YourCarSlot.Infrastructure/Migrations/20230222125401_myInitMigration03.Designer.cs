﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

#nullable disable

namespace YourCarSlot.Infrastructure.Migrations
{
    [DbContext(typeof(YCSDatabaseContext))]
    [Migration("20230222125401_myInitMigration03")]
    partial class myInitMigration03
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YourCarSlot.Domain.Entities.ParkingSlot", b =>
                {
                    b.Property<int?>("ParkingspotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ParkingspotId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("_levelId")
                        .HasColumnType("int");

                    b.HasKey("ParkingspotId");

                    b.ToTable("ParkingSlot");

                    b.HasData(
                        new
                        {
                            ParkingspotId = 1,
                            Id = new Guid("4c750373-6309-40c8-af68-973aaf8da562"),
                            levelId = 0
                        });
                });

            modelBuilder.Entity("YourCarSlot.Domain.Entities.ReservationRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookingRequestTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParkingspotId")
                        .HasColumnType("int");

                    b.Property<int>("PartOfTheDayReservation")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Reserved")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserRequestingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParkingspotId");

                    b.HasIndex("PlateNumber");

                    b.HasIndex("UserRequestingId");

                    b.ToTable("ReservationRequest");

                    b.HasData(
                        new
                        {
                            Id = new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                            BookingRequestTime = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Utc).AddTicks(8225),
                            CreatedAt = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8235),
                            DateModified = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8243),
                            PartOfTheDayReservation = 0,
                            PlateNumber = "23233-33",
                            Reserved = true,
                            UserRequestingId = new Guid("36b99c90-b13d-11ed-afa1-0242ac120002")
                        },
                        new
                        {
                            Id = new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                            BookingRequestTime = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Utc).AddTicks(8248),
                            CreatedAt = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8250),
                            DateModified = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8251),
                            PartOfTheDayReservation = 0,
                            PlateNumber = "44312413433-33",
                            Reserved = true,
                            UserRequestingId = new Guid("4428bf00-b13d-11ed-afa1-0242ac120002")
                        });
                });

            modelBuilder.Entity("YourCarSlot.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlateNumber");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"),
                            CreatedAt = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8505),
                            Email = "Wojciech@polo.pl",
                            FullName = "",
                            Password = "1234567",
                            Salt = "1",
                            Username = "DriftWojciech"
                        },
                        new
                        {
                            Id = new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"),
                            CreatedAt = new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8511),
                            Email = "Kubus@polo.pl",
                            FullName = "",
                            Password = "1234567",
                            Salt = "4",
                            Username = "pogczamp"
                        });
                });

            modelBuilder.Entity("YourCarSlot.Domain.Entities.Vehicle", b =>
                {
                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MakeOfCar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlateNumber");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            PlateNumber = "23233-33",
                            Id = new Guid("0a417db6-b1f3-11ed-afa1-0242ac120002"),
                            MakeOfCar = "bmw"
                        },
                        new
                        {
                            PlateNumber = "44312413433-33",
                            Id = new Guid("570bf312-e912-4911-b137-a902572e5b13"),
                            MakeOfCar = "Audi"
                        });
                });

            modelBuilder.Entity("YourCarSlot.Domain.Entities.ReservationRequest", b =>
                {
                    b.HasOne("YourCarSlot.Domain.Entities.ParkingSlot", "ParkingSlot")
                        .WithMany()
                        .HasForeignKey("ParkingspotId");

                    b.HasOne("YourCarSlot.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("PlateNumber");

                    b.HasOne("YourCarSlot.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserRequestingId");

                    b.Navigation("ParkingSlot");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("YourCarSlot.Domain.Entities.User", b =>
                {
                    b.HasOne("YourCarSlot.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("PlateNumber");

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
