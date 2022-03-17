﻿using Microsoft.EntityFrameworkCore;
using System;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.EntityFramework
{
    public class DeviceDbContext : DbContext
    {
        public DeviceDbContext(DbContextOptions<DeviceDbContext> options)
            : base(options) { }

        public DbSet<DeviceDomain.Device> Device { get; set; }
        public DbSet<DeviceDomain.DeviceDetails> DeviceDetails { get; set; }
        public DbSet<DeviceDomain.DevicesRelated> DevicesRelated { get; set; }
    }
}
