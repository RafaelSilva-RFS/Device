using Microsoft.EntityFrameworkCore.Migrations;

namespace Device.Identity.Migrations
{
    public partial class Seed_Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ee750272-d08b-42e6-86f9-862bceb86e94", 0, "d3261c8a-658e-4d26-87c6-74ae68a36257", "admin@device.com", true, false, null, "ADMIN@DEVICE.COM", "ADMIN@DEVICE.COM", "AQAAAAEAACcQAAAAEARfik5d6IaJPbbMaoCOFRe8zTiPJJnxoCtQMdL2vygTgF+tb2Ng6/wuqjyWllEmYg==", null, false, "LAMOUKGRG6MHEFR4KZCU7PYW4JE7HGI7", false, "admin@device.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee750272-d08b-42e6-86f9-862bceb86e94");
        }
    }
}
