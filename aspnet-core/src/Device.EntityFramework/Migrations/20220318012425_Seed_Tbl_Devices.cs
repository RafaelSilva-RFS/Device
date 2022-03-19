using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Device.EntityFramework.Migrations
{
    public partial class Seed_Tbl_Devices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreationTime", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), new DateTime(2022, 3, 17, 8, 31, 0, 0, DateTimeKind.Unspecified), false, "Work Smartphone", 0 },
                    { new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), new DateTime(2022, 3, 17, 10, 23, 0, 0, DateTimeKind.Unspecified), false, "Son Ipad", 1 },
                    { new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), new DateTime(2022, 3, 18, 9, 4, 0, 0, DateTimeKind.Unspecified), false, "Home Laptop", 3 },
                    { new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), new DateTime(2022, 3, 19, 11, 38, 0, 0, DateTimeKind.Unspecified), false, "Work Server", 2 },
                    { new Guid("6cd66acb-33c5-43a4-8987-5ef566ed524c"), new DateTime(2022, 3, 19, 15, 38, 0, 0, DateTimeKind.Unspecified), false, "School Desktop", 2 },
                    { new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), new DateTime(2022, 3, 19, 17, 38, 0, 0, DateTimeKind.Unspecified), false, "Hall Television", 6 },
                    { new Guid("4274be17-8e8e-4012-8be4-978579607f3a"), new DateTime(2022, 3, 20, 10, 23, 0, 0, DateTimeKind.Unspecified), false, "Mom Ipad", 1 },
                    { new Guid("46c2ae34-db80-40d1-ac73-d9b01eaf511c"), new DateTime(2022, 3, 21, 9, 4, 0, 0, DateTimeKind.Unspecified), false, "Daughter Laptop", 3 },
                    { new Guid("edd25796-460b-4da4-8340-4a283024d506"), new DateTime(2022, 3, 21, 11, 38, 0, 0, DateTimeKind.Unspecified), false, "Bedroom TV", 6 },
                    { new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), new DateTime(2022, 3, 23, 15, 38, 0, 0, DateTimeKind.Unspecified), false, "Mom Smartphone", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("4274be17-8e8e-4012-8be4-978579607f3a"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("46c2ae34-db80-40d1-ac73-d9b01eaf511c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("6cd66acb-33c5-43a4-8987-5ef566ed524c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("edd25796-460b-4da4-8340-4a283024d506"));
        }
    }
}
