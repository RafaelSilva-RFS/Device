using Device.DomainShared.Device.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.EntityFramework
{
    public class DeviceDbContext : DbContext
    {
        public DeviceDbContext(DbContextOptions<DeviceDbContext> options)
            : base(options) { }

        public DbSet<DeviceDomain.Device> Device { get; set; }
        public DbSet<DeviceDomain.DeviceDetails> DeviceDetails { get; set; }
        //public DbSet<DeviceDomain.DevicesRelated> DevicesRelated { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Devices Table Seed
            modelBuilder.Entity<DeviceDomain.Device>().HasData(
                new DeviceDomain.Device
                {
                    Id = new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"),
                    Name = "Work Smartphone",
                    Type = DeviceType.Smartphone,
                    CreationTime = DateTime.ParseExact("03/17/2022 08:31", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"),
                    Name = "Son Ipad",
                    Type = DeviceType.Ipad,
                    CreationTime = DateTime.ParseExact("03/17/2022 10:23", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"),
                    Name = "Home Laptop",
                    Type = DeviceType.Laptop,
                    CreationTime = DateTime.ParseExact("03/18/2022 09:04", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"),
                    Name = "Work Server",
                    Type = DeviceType.Desktop,
                    CreationTime = DateTime.ParseExact("03/19/2022 11:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("6cd66acb-33c5-43a4-8987-5ef566ed524c"),
                    Name = "School Desktop",
                    Type = DeviceType.Desktop,
                    CreationTime = DateTime.ParseExact("03/19/2022 15:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"),
                    Name = "Hall Television",
                    Type = DeviceType.Television,
                    CreationTime = DateTime.ParseExact("03/19/2022 17:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("4274be17-8e8e-4012-8be4-978579607f3a"),
                    Name = "Mom Ipad",
                    Type = DeviceType.Ipad,
                    CreationTime = DateTime.ParseExact("03/20/2022 10:23", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("46c2ae34-db80-40d1-ac73-d9b01eaf511c"),
                    Name = "Daughter Laptop",
                    Type = DeviceType.Laptop,
                    CreationTime = DateTime.ParseExact("03/21/2022 09:04", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("edd25796-460b-4da4-8340-4a283024d506"),
                    Name = "Bedroom TV",
                    Type = DeviceType.Television,
                    CreationTime = DateTime.ParseExact("03/21/2022 11:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"),
                    Name = "Mom Smartphone",
                    Type = DeviceType.Smartphone,
                    CreationTime = DateTime.ParseExact("03/23/2022 15:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                }
            );
            #endregion
        }
    }
}
