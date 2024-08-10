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
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "PlateNumber" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Utc).AddTicks(3585), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3588), "44312413433-33" });

            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "PlateNumber" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Utc).AddTicks(3560), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3571), new DateTime(2023, 2, 22, 12, 17, 57, 668, DateTimeKind.Local).AddTicks(3581), "23233-33" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("34a130d2-502f-4cf1-a376-63edeb092137"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "PlateNumber" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Utc).AddTicks(5317), new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5321), "1337" });

            migrationBuilder.UpdateData(
                table: "ReservationRequest",
                keyColumn: "Id",
                keyValue: new Guid("81a130d2-502f-4cf1-a376-63edeb000e9f"),
                columns: new[] { "BookingRequestTime", "CreatedAt", "DateModified", "PlateNumber" },
                values: new object[] { new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Utc).AddTicks(5292), new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5302), new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5313), "2115" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36b99c90-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4428bf00-b13d-11ed-afa1-0242ac120002"),
                column: "CreatedAt",
                value: new DateTime(2023, 2, 22, 12, 11, 47, 384, DateTimeKind.Local).AddTicks(5577));
        }
    }
}
