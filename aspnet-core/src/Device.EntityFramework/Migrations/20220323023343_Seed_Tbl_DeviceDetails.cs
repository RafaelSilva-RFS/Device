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
                    { new Guid("39c77279-fa83-493d-8581-e1771c7d7c1e"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 30.458f, 5437547f },
                    { new Guid("f27deca6-efc1-49dc-85e6-48ecac1dcd82"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("8f458b6f-40d7-48ac-9277-6727c45cfd22"), false, 30.458f, 3463443f },
                    { new Guid("8eb6a5be-86f6-4760-bf2e-b1e2ee3ac50b"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("cde3b44e-9603-4fc4-89b4-a027c3aab5eb"), false, 31.98f, 23523524f },
                    { new Guid("14b782bc-ce4f-4600-b75d-fce170dc2333"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("cde3b44e-9603-4fc4-89b4-a027c3aab5eb"), false, 32.458f, 321532f },
                    { new Guid("69b50dc5-4fa5-4056-8280-e0c615988df3"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("cde3b44e-9603-4fc4-89b4-a027c3aab5eb"), false, 30.458f, 3463443f },
                    { new Guid("993ae2c5-5495-4abe-98ec-12c6ecc9bbc1"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("5b9eda9d-d878-4b6d-b041-11e725bcccd4"), false, 31.98f, 23523524f },
                    { new Guid("ee482c35-de11-4030-9515-323500db08de"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("5b9eda9d-d878-4b6d-b041-11e725bcccd4"), false, 32.458f, 321532f },
                    { new Guid("f5aa9b1a-370f-4a80-9a22-8ebe49722258"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("5b9eda9d-d878-4b6d-b041-11e725bcccd4"), false, 30.458f, 3463443f },
                    { new Guid("85ae8097-a6bb-4933-9adb-2114f11c6c29"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 31.98f, 23523524f },
                    { new Guid("07865b3b-5559-4246-937f-46661f694361"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 32.458f, 321532f },
                    { new Guid("620fb4d1-bb9e-479a-8583-655aefc13265"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"), false, 30.458f, 3463443f },
                    { new Guid("21ad706c-08bb-406d-bb7f-33890b908462"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 30.358f, 23523f },
                    { new Guid("6793f594-aeff-4e9d-8b34-05968f732de7"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 33.458f, 235235f },
                    { new Guid("b2d11652-c5e5-4093-93e6-ff8ed032c95f"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("edd25796-460b-4da4-8340-4a283024d506"), false, 30.458f, 451552f },
                    { new Guid("4f80e15a-b2af-4f86-b403-000218729525"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 30.748f, 32532524f },
                    { new Guid("cf9f402f-2ba1-4080-a674-14ad0eea9824"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 30.658f, 2352352f },
                    { new Guid("5e600eb4-597b-40a4-a5f6-6b44b90b6ef2"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"), false, 29.458f, 451552f },
                    { new Guid("40539503-7919-4f68-892a-e010918df244"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 30.458f, 2652355f },
                    { new Guid("18029775-3e1c-4d5f-8f09-1b10cf7eb6ed"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 32.38f, 7363445f },
                    { new Guid("c9f95416-8cd0-4e0c-a73f-de52c9be2d89"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"), false, 31.458f, 367357f },
                    { new Guid("37d22d4d-23c0-41ca-91a5-072a70da5d83"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 30.458f, 43633f },
                    { new Guid("b22769e6-efb1-4502-8d1e-6568db4dbd1f"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 28.458f, 145125f },
                    { new Guid("d4419940-6f1a-48fd-9499-79594f20cb9a"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"), false, 31.458f, 262623f },
                    { new Guid("fa73f6c9-fe68-4e18-bf8b-c17ad8fa9373"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 35.458f, 6345532f },
                    { new Guid("99ac592a-5123-4a63-94a1-cd161153d79e"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 34.5658f, 52346248f },
                    { new Guid("9f2d9e79-c201-428e-bb50-ec9afe7bfa25"), new DateTime(2022, 3, 23, 8, 30, 0, 0, DateTimeKind.Unspecified), new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"), false, 29.4458f, 236525f },
                    { new Guid("15096be5-4434-4622-bcc7-79ac960be0c9"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 32.5458f, 7564754f },
                    { new Guid("f51b1e84-71af-4987-b649-29d35cc8ac7b"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"), false, 28.458f, 5423818f },
                    { new Guid("cde4793b-6af4-4aad-91b6-3eae2bf347c2"), new DateTime(2022, 3, 23, 8, 40, 0, 0, DateTimeKind.Unspecified), new Guid("8f458b6f-40d7-48ac-9277-6727c45cfd22"), false, 32.458f, 321532f },
                    { new Guid("d574f9d8-47ae-4e6b-8d2d-355e9cf63016"), new DateTime(2022, 3, 23, 8, 50, 0, 0, DateTimeKind.Unspecified), new Guid("8f458b6f-40d7-48ac-9277-6727c45cfd22"), false, 31.98f, 23523524f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("07865b3b-5559-4246-937f-46661f694361"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("14b782bc-ce4f-4600-b75d-fce170dc2333"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("15096be5-4434-4622-bcc7-79ac960be0c9"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("18029775-3e1c-4d5f-8f09-1b10cf7eb6ed"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("21ad706c-08bb-406d-bb7f-33890b908462"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("37d22d4d-23c0-41ca-91a5-072a70da5d83"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("39c77279-fa83-493d-8581-e1771c7d7c1e"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("40539503-7919-4f68-892a-e010918df244"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("4f80e15a-b2af-4f86-b403-000218729525"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("5e600eb4-597b-40a4-a5f6-6b44b90b6ef2"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("620fb4d1-bb9e-479a-8583-655aefc13265"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("6793f594-aeff-4e9d-8b34-05968f732de7"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("69b50dc5-4fa5-4056-8280-e0c615988df3"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("85ae8097-a6bb-4933-9adb-2114f11c6c29"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("8eb6a5be-86f6-4760-bf2e-b1e2ee3ac50b"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("993ae2c5-5495-4abe-98ec-12c6ecc9bbc1"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("99ac592a-5123-4a63-94a1-cd161153d79e"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("9f2d9e79-c201-428e-bb50-ec9afe7bfa25"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("b22769e6-efb1-4502-8d1e-6568db4dbd1f"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("b2d11652-c5e5-4093-93e6-ff8ed032c95f"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("c9f95416-8cd0-4e0c-a73f-de52c9be2d89"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("cde4793b-6af4-4aad-91b6-3eae2bf347c2"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf9f402f-2ba1-4080-a674-14ad0eea9824"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("d4419940-6f1a-48fd-9499-79594f20cb9a"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("d574f9d8-47ae-4e6b-8d2d-355e9cf63016"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("ee482c35-de11-4030-9515-323500db08de"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("f27deca6-efc1-49dc-85e6-48ecac1dcd82"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("f51b1e84-71af-4987-b649-29d35cc8ac7b"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5aa9b1a-370f-4a80-9a22-8ebe49722258"));

            migrationBuilder.DeleteData(
                table: "DeviceDetails",
                keyColumn: "Id",
                keyValue: new Guid("fa73f6c9-fe68-4e18-bf8b-c17ad8fa9373"));
        }
    }
}
