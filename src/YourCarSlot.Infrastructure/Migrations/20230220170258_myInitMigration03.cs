using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YourCarSlot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class myInitMigration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "Reserved" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Utc).AddTicks(9421), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9424), true });

            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "Reserved" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Utc).AddTicks(9399), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9416), true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateModified", "Email", "FullName", "Password", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9856), null, "Wojciech@polo.pl", "", "1234567", "1", "DriftWojciech" },
                    { new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"), new DateTime(2023, 2, 20, 17, 2, 58, 336, DateTimeKind.Local).AddTicks(9863), null, "Kubus@polo.pl", "", "1234567", "4", "pogczamp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"));

            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "Reserved" },
                values: new object[] { new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6616), false });

            migrationBuilder.UpdateData(
                table: "ReservationRequests",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "Reserved" },
                values: new object[] { new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 2, 7, 17, 20, 55, 701, DateTimeKind.Local).AddTicks(6609), false });
        }
    }
}
