using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Device.EntityFramework.Migrations
{
    public partial class Seed_Tbl_DeviceDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeviceDetails",
                columns: new[] { "Id", "CreationTime", "DeviceId", "IsDeleted", "Temperature", "Usage" },
                values: new object[,]
                {
                    { new Guid("a6114d42-3a47-4885-9191-60a1ca6d2d33"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 30.458f, 5437547f },
                    { new Guid("ee964760-1c37-47a2-814b-431b775eef4a"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 30.458f, 3463443f },
                    { new Guid("f6c00033-0301-42f1-896e-532ca2585873"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 30.358f, 23523f },
                    { new Guid("134c9061-afa3-4fa8-97e6-6a5d876000b0"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 33.458f, 235235f },
                    { new Guid("d123c91e-36ff-463f-a33d-7948f5549439"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 30.458f, 451552f },
                    { new Guid("433b8da2-7aee-4fc6-a580-7da212c0f58d"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 30.748f, 32532524f },
                    { new Guid("f1916e35-0497-4c32-95f4-64bd41a9f6fb"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 30.658f, 2352352f },
                    { new Guid("fb898af6-b59c-42b7-a861-220ec1b683a0"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 29.458f, 451552f },
                    { new Guid("93dee4b7-172a-4016-9e33-709b2af32153"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 30.458f, 2652355f },
                    { new Guid("9ffb6f9f-9b8c-4e4b-aeda-4653b8b4df53"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 32.458f, 321532f },
                    { new Guid("65cc08bd-7fe3-4067-b659-7de85747571c"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 32.38f, 7363445f },
                    { new Guid("4eaeaf69-0157-4252-b980-1440fb347068"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 30.458f, 43633f },
                    { new Guid("4ec35344-5deb-4393-9403-38bb4e751c64"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 28.458f, 145125f },
                    { new Guid("36afe48d-679e-4044-8035-36a33216f031"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 31.458f, 262623f },
                    { new Guid("d33b0f4d-6df4-473d-a2e1-0f290bd0a80c"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 35.458f, 6345532f },
                    { new Guid("08f6848c-27a2-41a9-a587-890d7512acb9"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 34.5658f, 52346248f },
                    { new Guid("38896a30-53dd-4936-8ffd-1347730867ae"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 29.4458f, 236525f },
                    { new Guid("c8975a67-e770-4a3a-bf35-0c205e99ba2d"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 32.5458f, 7564754f },
                    { new Guid("d777861f-92f3-4688-b389-ec6ed33dd86b"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 28.458f, 5423818f },
                    { new Guid("36cb705c-acf6-438f-9f69-324a13a0e56a"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 31.458f, 367357f },
                    { new Guid("eeff1c90-d32e-4303-8744-d139c219666c"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 31.98f, 23523524f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("08f6848c-27a2-41a9-a587-890d7512acb9"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("134c9061-afa3-4fa8-97e6-6a5d876000b0"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("36afe48d-679e-4044-8035-36a33216f031"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("36cb705c-acf6-438f-9f69-324a13a0e56a"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("38896a30-53dd-4936-8ffd-1347730867ae"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("433b8da2-7aee-4fc6-a580-7da212c0f58d"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("4eaeaf69-0157-4252-b980-1440fb347068"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("4ec35344-5deb-4393-9403-38bb4e751c64"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("65cc08bd-7fe3-4067-b659-7de85747571c"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("93dee4b7-172a-4016-9e33-709b2af32153"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("9ffb6f9f-9b8c-4e4b-aeda-4653b8b4df53"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6114d42-3a47-4885-9191-60a1ca6d2d33"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("c8975a67-e770-4a3a-bf35-0c205e99ba2d"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("d123c91e-36ff-463f-a33d-7948f5549439"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("d33b0f4d-6df4-473d-a2e1-0f290bd0a80c"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("d777861f-92f3-4688-b389-ec6ed33dd86b"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("ee964760-1c37-47a2-814b-431b775eef4a"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("eeff1c90-d32e-4303-8744-d139c219666c"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1916e35-0497-4c32-95f4-64bd41a9f6fb"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("f6c00033-0301-42f1-896e-532ca2585873"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("fb898af6-b59c-42b7-a861-220ec1b683a0"));
        }
    }
}
