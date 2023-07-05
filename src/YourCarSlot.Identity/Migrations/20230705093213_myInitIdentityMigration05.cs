using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Identity.Migrations
{
    /// <inheritdoc />
    public partial class myInitIdentityMigration05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2e08085-cf43-484e-aebc-a2aaaf7ba87f", "532facd9-f5a8-4e7b-913b-2ffa16412c37" });

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "f5c403c7-fbd5-4562-83d6-9430255f5f73", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2e08085-cf43-484e-aebc-a2aaaf7ba87f", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", 0, "deae64d4-3c3e-4c2b-8e16-502b546c734a", "guest@localhost.com", true, "System", "Guest", false, null, "GUEST@LOCALHOST.COM", "GUEST@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBSDJxPzeQb8zHPZeD5jZ1rYVfZ4ni+usfztoXb2je8Uioq9kDZC2jNGtnoOKHtZxw==", null, false, "f6a01a74-1b86-4387-9689-3ad78a85f435", false, "guest@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2e08085-cf43-484e-aebc-a2aaaf7ba87f", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2a0bf08-cbd9-42ad-a847-bfc2830ce604", "0a9681ac-a390-4952-9d2a-dd431eae01aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2a0bf08-cbd9-42ad-a847-bfc2830ce604");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "f8b653c3-47e0-43ed-97de-1270fb5aa94b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "7e0df075-a898-4969-9d93-f173b4a6abbf");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2e08085-cf43-484e-aebc-a2aaaf7ba87f", "532facd9-f5a8-4e7b-913b-2ffa16412c37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87b2b3d1-19f9-48f7-996d-39d815d15b98", "AQAAAAEAACcQAAAAEEChiqWNz/XkqcbdK2BW3fzhn1GuyujGHMEx/XiPJGrclONoi/NbH+pIqJJJFFHNvA==", "c273b9d1-d29a-4ad8-b0ce-34ab546c9b44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b57710c-2cad-4b56-9d0d-32fbce668612", "AQAAAAEAACcQAAAAEO4Mh7wptodZzwVB2Aipl6ELiDc++sccy6paf904q0jI6pTBIc86g0DZyuNpyberCA==", "ec001113-e291-40b4-baf7-87e0837dd865" });
        }
    }
}
