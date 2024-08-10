using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class myInitMigration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Utc).AddTicks(8248), new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Utc).AddTicks(8225), new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8235), new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 54, 1, 358, DateTimeKind.Local).AddTicks(8511));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Utc).AddTicks(3585), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Utc).AddTicks(3560), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3571), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3837));
        }
    }
}
