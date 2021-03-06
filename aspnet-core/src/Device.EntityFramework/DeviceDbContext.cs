using Microsoft.EntityFrameworkCore;
using DeviceDomain = Device.Domain.Device.Entities;

namespace Device.EntityFramework
{
    public class DeviceDbContext : DbContext
    {
        public DeviceDbContext(DbContextOptions<DeviceDbContext> options)
            : base(options) { }

        public DbSet<DeviceDomain.Device> Devices { get; set; }
        public DbSet<DeviceDomain.DeviceDetails> DeviceDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureDevice();
        }
    }
}
