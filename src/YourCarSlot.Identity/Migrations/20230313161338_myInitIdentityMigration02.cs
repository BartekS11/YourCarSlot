using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourCarSlot.Identity.Migrations
{
    /// <inheritdoc />
    public partial class myInitIdentityMigration02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "e720ccbb-b52e-4ea1-b910-2ea44c5270a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "d22f68e6-cb04-45bb-adca-00544c96c222");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645dacc0-d050-4dc2-92e4-70ce3387449e", "AQAAAAEAACcQAAAAEMEcXG++jvTV8ETXPdl942tp//cI7qf28a6Fr0hN3u7zd+vENoi6r6Zkd6G1YclbKw==", "3934044a-3f1c-4a67-9c65-891ddd1aa0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c7051c-967e-4ae3-bdec-a1b443674e73", "AQAAAAEAACcQAAAAEL/UY9w3ewa8ls25W22YT/umN/u7w1nZZ0ZkOHe/gDabRNAGa4BTZL9lCTqsEZ6UEQ==", "54356d12-011a-4849-b0c1-a1782b4667bd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546ff490-b5df-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "40b19e51-7edc-4a6e-b91a-64c272ec0e40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e08085-cf43-484e-aebc-a2aaaf7ba87f",
                column: "ConcurrencyStamp",
                value: "f89e8da3-e952-42d2-bfb7-2cad7d593351");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9681ac-a390-4952-9d2a-dd431eae01aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a5243b5-1982-4155-ad91-7db3dd5ce0e9", "AQAAAAEAACcQAAAAEFE8vT4gQqgavV6rhuZp1ko0qOFyqZHINPkNV54nRSGquE7+U9XA5kNhkrMxyG0ZWA==", "5b68f90b-4064-4f3e-96fc-82ea3af0859a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "532facd9-f5a8-4e7b-913b-2ffa16412c37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4a45c0-3092-4019-9859-c23cf2a7fefe", "AQAAAAEAACcQAAAAEB/wbWoKkgzmoP6FUUMyK5VKU5JHfqQVnl5B4LowM5zPukRISu+HIHr3HIZKungJgw==", "9d072493-09de-48f4-b7b1-881625b8cabe" });
        }
    }
}
