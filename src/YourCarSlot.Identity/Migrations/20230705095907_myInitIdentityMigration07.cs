using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Identity.Migrations
{
    /// <inheritdoc />
    public partial class myInitIdentityMigration07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "a507dae7-c55d-482a-81f4-2a2fe17b2cb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "63b5df58-40d7-4828-86fd-ec7d4f00e983");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "276e10de-2050-4ad3-95f9-33c417ecdbd2", "c3448803-9edd-4d95-9252-3da054bd06dd", "Guest", "GUEST" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c43d307-9270-4e17-88cb-8d1d19e95e66", "AQAAAAEAACcQAAAAEPvHHY85ONkXroTiIII3XZzZ+bb2WvLaLz4s2RFFH/TK9DosJEiGKfYXLeZl+i13Sg==", "4a142ba5-6bc7-4006-ba30-342696e37f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d68ef763-f324-4cbf-b116-728388fba3dc", "AQAAAAEAACcQAAAAEKc2uFxPqVQVpx8aS4aqzrLukbG82zXdlo144SKwA8q0+bDU43vzE8OaqwUi8SACaA==", "a4c88caa-2eed-466e-8773-47c52e4c1e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05d0549b-aa87-489c-b0a4-da245f59bac1", "AQAAAAEAACcQAAAAEMEIBpM50iUUO1Ql8R8KDBR/9TGrxUGTT/3SrWBo17yqQMjKtu9l56ib/2AznaoGOQ==", "cacb95dd-38ee-4bb6-a439-48a01fa204f7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "276e10de-2050-4ad3-95f9-33c417ecdbd2", "e2a0bf08-cbd9-42ad-a847-bfc2830ce604" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "276e10de-2050-4ad3-95f9-33c417ecdbd2", "e2a0bf08-cbd9-42ad-a847-bfc2830ce604" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "276e10de-2050-4ad3-95f9-33c417ecdbd2");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "ddbc2212-5bab-4db2-9f98-93d45bff7231", "Guest", "GUEST" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });
        }
    }
}
