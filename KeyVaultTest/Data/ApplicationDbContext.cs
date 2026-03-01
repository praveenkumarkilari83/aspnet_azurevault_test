using Microsoft.EntityFrameworkCore;
using KeyVaultTest.Models;

namespace KeyVaultTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LoginUser> LoginUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoginUser>()
                .ToTable("login", schema: "dbo");

            modelBuilder.Entity<LoginUser>()
                .Property(u => u.Username)
                .HasColumnName("Username")
                .IsRequired();

            modelBuilder.Entity<LoginUser>()
                .Property(u => u.Password)
                .HasColumnName("Password")
                .IsRequired();
        }
    }
}