using Device.DomainShared.Device.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.EntityFramework
{
    public static class DeviceDbContextModelCreatingExtensions
    {
        public static void ConfigureDevice(this ModelBuilder modelBuilder)
        {
            #region Devices Table Seed
            modelBuilder.Entity<DeviceDomain.Device>().HasData(
                new DeviceDomain.Device
                {
                    Id = new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"),
                    Name = "Work Smartphone",
                    Type = DeviceType.Smartphone,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/17/2022 08:31", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"),
                    Name = "Son Ipad",
                    Type = DeviceType.Ipad,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/17/2022 10:23", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"),
                    Name = "Home Laptop",
                    Type = DeviceType.Laptop,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/18/2022 09:04", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"),
                    Name = "Hall Television",
                    Type = DeviceType.Television,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/19/2022 17:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"),
                    Name = "Work Server",
                    Type = DeviceType.Desktop,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/19/2022 11:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("edd25796-460b-4da4-8340-4a283024d506"),
                    Name = "Bedroom TV",
                    Type = DeviceType.Television,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/21/2022 11:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.Device
                {
                    Id = new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"),
                    Name = "Mom Smartphone",
                    Type = DeviceType.Smartphone,
                    Status = DeviceStatus.Available,
                    CreationTime = DateTime.ParseExact("03/22/2022 15:38", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                }
            );
            #endregion

            #region Seed DeviceDetails
            modelBuilder.Entity<DeviceDomain.DeviceDetails>().HasData(
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"),
                    Temperature = 30.458f,
                    Usage = 5437547,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"),
                    Temperature = 28.458f,
                    Usage = 5423818,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7c00b09f-4562-4e2f-b95d-edd6e2240b96"),
                    Temperature = 32.5458f,
                    Usage = 7564754,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },

                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"),
                    Temperature = 29.4458f,
                    Usage = 236525,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"),
                    Temperature = 34.5658f,
                    Usage = 52346246,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("98ec6ea5-d591-47f3-9f36-c1c9f2a3316c"),
                    Temperature = 35.458f,
                    Usage = 6345532,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },

                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"),
                    Temperature = 31.458f,
                    Usage = 262623,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"),
                    Temperature = 28.458f,
                    Usage = 145125,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("0e05ba9d-a84f-48da-bd1d-19eaabfe1590"),
                    Temperature = 30.458f,
                    Usage = 43633,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },

                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"),
                    Temperature = 31.458f,
                    Usage = 367357,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"),
                    Temperature = 32.38f,
                    Usage = 7363445,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },
                new DeviceDomain.DeviceDetails
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("7fa37ac2-9edf-469f-8d2a-535aab49b00e"),
                    Temperature = 30.458f,
                    Usage = 2652355,
                    CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
                },

            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"),
                Temperature = 29.458f,
                Usage = 451552,
                CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"),
                Temperature = 30.658f,
                Usage = 2352352,
                CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("b2780a57-cce2-4244-9c28-5cee4c04f6b7"),
                Temperature = 30.748f,
                Usage = 32532523,
                CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },

            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("edd25796-460b-4da4-8340-4a283024d506"),
                Temperature = 30.458f,
                Usage = 451552,
                CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("edd25796-460b-4da4-8340-4a283024d506"),
                Temperature = 33.458f,
                Usage = 235235,
                CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("edd25796-460b-4da4-8340-4a283024d506"),
                Temperature = 30.358f,
                Usage = 23523,
                CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },

            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"),
                Temperature = 30.458f,
                Usage = 3463443,
                CreationTime = DateTime.ParseExact("03/23/2022 08:30", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"),
                Temperature = 32.458f,
                Usage = 321532,
                CreationTime = DateTime.ParseExact("03/23/2022 08:40", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            },
            new DeviceDomain.DeviceDetails
            {
                Id = Guid.NewGuid(),
                DeviceId = new Guid("9bea121f-ae8e-4db3-b433-419596e573eb"),
                Temperature = 31.98f,
                Usage = 23523523,
                CreationTime = DateTime.ParseExact("03/23/2022 08:50", "MM/dd/yyyy HH:mm", new CultureInfo("en-US"))
            }

            );
            #endregion
        }
    }
}
