using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class myInitMigration02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.InsertData(
                table: "ReservationRequests",
                columns: new[] { "Id", "BookingRequestTime", "CreatedAt", "DateModified", "ParkingSlotRequesting", "PartOfTheDayReservation", "PlateNumber", "Reserved", "UserRequestingId" },
                values: new object[] { new Guid("34a130d2-502f-4cf1-a376-63edeb092137"), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6616), 1, 0, "3123-466-221", false, new Guid("25a130d2-502f-4cf1-a376-63edeb027212") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"));

            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 7, 16, 38, 37, 765, DateTimeKind.Utc).AddTicks(8521), new DateTime(2023, 2, 7, 16, 38, 37, 765, DateTimeKind.Local).AddTicks(8526), new DateTime(2023, 2, 7, 16, 38, 37, 765, DateTimeKind.Local).AddTicks(8541) });
        }
    }
}
