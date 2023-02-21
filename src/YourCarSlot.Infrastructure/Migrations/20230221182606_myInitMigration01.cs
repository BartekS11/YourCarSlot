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
                name: "ParkingSlot",
                columns: table => new
                {
                    ParkingspotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    levelId = table.Column<int>(name: "_levelId", type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSlot", x => x.ParkingspotId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    PlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakeOfCar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.PlateNumber);
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
                    PlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Vehicles_PlateNumber",
                        column: x => x.PlateNumber,
                        principalTable: "Vehicles",
                        principalColumn: "PlateNumber");
                });

            migrationBuilder.CreateTable(
                name: "ReservationRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartOfTheDayReservation = table.Column<int>(type: "int", nullable: false),
                    BookingRequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRequestingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingspotId = table.Column<int>(type: "int", nullable: true),
                    Reserved = table.Column<bool>(type: "bit", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationRequest_ParkingSlot_ParkingspotId",
                        column: x => x.ParkingspotId,
                        principalTable: "ParkingSlot",
                        principalColumn: "ParkingspotId");
                    table.ForeignKey(
                        name: "FK_ReservationRequest_Users_UserRequestingId",
                        column: x => x.UserRequestingId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservationRequest_Vehicles_PlateNumber",
                        column: x => x.PlateNumber,
                        principalTable: "Vehicles",
                        principalColumn: "PlateNumber");
                });

            migrationBuilder.InsertData(
                table: "ParkingSlot",
                columns: new[] { "ParkingspotId", "CreatedAt", "DateModified", "Id", "_levelId" },
                values: new object[] { 1, null, null, new Guid("4c750373-6309-40c8-af68-973aaf8da562"), 0 });

            migrationBuilder.InsertData(
                table: "ReservationRequest",
                columns: new[] { "Id", "BookingRequestTime", "CreatedAt", "DateModified", "ParkingspotId", "PartOfTheDayReservation", "PlateNumber", "Reserved", "UserRequestingId" },
                values: new object[,]
                {
                    { new Guid("34a130d2-502f-4cf1-a376-63edeb092137"), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(6848), null, 0, null, true, null },
                    { new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Utc).AddTicks(6826), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(6842), null, 0, null, true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateModified", "Email", "FullName", "Password", "PlateNumber", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(7139), null, "Wojciech@polo.pl", "", "1234567", null, "1", "DriftWojciech" },
                    { new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 21, 18, 26, 6, 428, DateTimeKind.Local).AddTicks(7145), null, "Kubus@polo.pl", "", "1234567", null, "4", "pogczamp" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "PlateNumber", "CreatedAt", "DateModified", "Id", "MakeOfCar" },
                values: new object[,]
                {
                    { "23233-33", null, null, new Guid("0a417db6-b1f3-11ed-afa1-0242ac120002"), "bmw" },
                    { "44312413433-33", null, null, new Guid("570bf312-e912-4911-b137-a902572e5b13"), "Audi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRequest_ParkingspotId",
                table: "ReservationRequest",
                column: "ParkingspotId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRequest_PlateNumber",
                table: "ReservationRequest",
                column: "PlateNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRequest_UserRequestingId",
                table: "ReservationRequest",
                column: "UserRequestingId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlateNumber",
                table: "Users",
                column: "PlateNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationRequest");

            migrationBuilder.DropTable(
                name: "ParkingSlot");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
