using HestiaStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace HestiaStore.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Agency>();
            modelBuilder.Entity<Chat>();
            modelBuilder.Entity<City>();
            modelBuilder.Entity<DwellingType>();
            modelBuilder.Entity<EnergyLabel>();
            modelBuilder.Entity<Home>();
            modelBuilder.Entity<Location>();
            modelBuilder.Entity<TargetGroup>();
        }
    }
}