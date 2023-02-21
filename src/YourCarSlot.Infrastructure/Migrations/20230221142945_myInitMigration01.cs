using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YourCarSlot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class myInitMigration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingSlots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartOfTheDayReservation = table.Column<int>(type: "int", nullable: false),
                    BookingRequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRequestingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingSlotRequesting = table.Column<int>(type: "int", nullable: false),
                    Reserved = table.Column<bool>(type: "bit", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakeOfCar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkingSlots",
                columns: new[] { "Id", "CreatedAt", "DateModified" },
                values: new object[] { new Guid("4c750373-6309-40c8-af68-973aaf8da562"), null, null });

            migrationBuilder.InsertData(
                table: "ReservationRequests",
                columns: new[] { "Id", "BookingRequestTime", "CreatedAt", "DateModified", "ParkingSlotRequesting", "PartOfTheDayReservation", "PlateNumber", "Reserved", "UserRequestingId" },
                values: new object[,]
                {
                    { new Guid("34a130d2-502f-4cf1-a376-63edeb092137"), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7330), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7331), 1, 0, "3123-466-221", true, new Guid("25a130d2-502f-4cf1-a376-63edeb027212") },
                    { new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7314), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7324), 4, 0, "4324-1345-53", true, new Guid("25a130d2-502f-4cf1-a376-63edeb027212") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateModified", "Email", "FullName", "Password", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7581), null, "Wojciech@polo.pl", "", "1234567", "1", "DriftWojciech" },
                    { new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 21, 14, 29, 45, 88, DateTimeKind.Local).AddTicks(7587), null, "Kubus@polo.pl", "", "1234567", "4", "pogczamp" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CreatedAt", "DateModified", "MakeOfCar", "PlateNumber" },
                values: new object[] { new Guid("0a417db6-b1f3-11ed-afa1-0242ac120002"), null, null, "bmw", "23233-33" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingSlots");

            migrationBuilder.DropTable(
                name: "ReservationRequests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
