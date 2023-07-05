using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Identity.Migrations
{
    /// <inheritdoc />
    public partial class myInitIdentityMigration06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "907662bd-35ca-4dd7-bab2-3035487d342b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "74008265-cf2e-47a6-85f9-5122d98d7a1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604",
                column: "ConcurrencyStamp",
                value: "ddbc2212-5bab-4db2-9f98-93d45bff7231");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01d82570-c190-4569-b2e7-4988c2e12805", "AQAAAAEAACcQAAAAEA4R9oO3JY0RttuLiCOMSqIB0+7Q+mfHoolgLCj6rinzQEtgI/8aSKvQaFR+0hBwyA==", "06712a89-a92b-44be-ad16-e859258f20ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48ac9570-b417-420e-b92e-cfff931d54c1", "AQAAAAEAACcQAAAAEFDEKYKTf8J4nqsarPsVTdmgAzJcXhkcr1mM5SUZT2AzzjGtcDi/QTvK78TfYTzvZw==", "48a405cc-48de-49b9-80bb-e717606e86cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b139b69-a2ed-4b26-b922-66ed2abf7970", "AQAAAAEAACcQAAAAEON6TXVStEGz7hLNgcdwr2nkZc15PsPUZk6LAtH0iD2LLYc6y4ZBZLcBl+JxZEaKIg==", "ea1fc488-faf9-40e0-b944-99a40174c64e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "627785c7-349e-4728-bb20-b6d01ceec2b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "49f7d0a6-d2a0-42db-a0c2-033b9763d5aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604",
                column: "ConcurrencyStamp",
                value: "f5c403c7-fbd5-4562-83d6-9430255f5f73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7acdc00d-7d58-4976-9cc8-337728e85e51", "AQAAAAEAACcQAAAAEL9NOZLVkFnypg7mHq3zCvFiNd37hqTp+hpB7euR+AkkuohTxu7vGxN8mqXSq3aUGw==", "c3b898b1-48f1-49b0-92d2-fc800c9bb65a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9bef49d-76f3-4c96-958c-cb6886dc7b53", "AQAAAAEAACcQAAAAEN98FaRkFpl0S7McKkcOtNCm2MfGtZvJz4GN4BU9FFNnOMwSf2l+yhTlUUal37oSbA==", "2b18f825-27f8-4fc5-a303-f7768dc1e306" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deae64d4-3c3e-4c2b-8e16-502b546c734a", "AQAAAAEAACcQAAAAEBSDJxPzeQb8zHPZeD5jZ1rYVfZ4ni+usfztoXb2je8Uioq9kDZC2jNGtnoOKHtZxw==", "f6a01a74-1b86-4387-9689-3ad78a85f435" });
        }
    }
}
