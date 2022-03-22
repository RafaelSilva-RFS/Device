using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

namespace Device.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
        }
    }

    public class AdminConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var admin = new IdentityUser
            {
                Id = "ee750272-d08b-42e6-86f9-862bceb86e94",
                UserName = "admin@device.com",
                NormalizedUserName = "ADMIN@DEVICE.COM",
                Email = "admin@device.com",
                NormalizedEmail = "ADMIN@DEVICE.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEMZGLhqSBdgU8e424GzSDF39KQCoJgqWyajtWbRj6akLfHRrB9vx6Apmwrs/TvVN+A==",
                SecurityStamp = "LAMOUKGRG6MHEFR4KZCU7PYW4JE7HGI7",
                ConcurrencyStamp = "d3261c8a-658e-4d26-87c6-74ae68a36257",
                LockoutEnabled = false,
                TwoFactorEnabled = false
                
            };

            admin.PasswordHash = PassGenerate(admin);

            builder.HasData(admin);
        }

        public string PassGenerate(IdentityUser user)
        {
            var passHash = new PasswordHasher<IdentityUser>();
            return passHash.HashPassword(user, "1q2w3E*");
        }
    }


    public class YourDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DeviceDb;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
