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

            modelBuilder.Entity<Agency>()
                        .HasMany<Home>(agency => (IEnumerable<Home>?)agency.Homes);

            modelBuilder.Entity<Chat>();

            modelBuilder.Entity<City>()
                        .HasOne<Location>(city => (Location?)city.Gemeente);

            modelBuilder.Entity<DwellingType>();

            modelBuilder.Entity<EnergyLabel>();

            modelBuilder.Entity<Home>()
                        .HasOne<City>(home => (City?)home.City)
                        .WithMany();

            modelBuilder.Entity<Home>()
                        .HasOne<Agency>(home => (Agency?)home.Agency);

            modelBuilder.Entity<Home>()
                        .HasOne<Location>(home => (Location?)home.Municipality)
                        .WithMany();

            modelBuilder.Entity<Home>()
                        .HasOne<DwellingType>(home => (DwellingType?)home.DwellingType)
                        .WithMany();

            modelBuilder.Entity<Home>()
                        .HasOne<EnergyLabel>(home => (EnergyLabel?)home.EnergyLabel)
                        .WithMany();

            modelBuilder.Entity<Home>()
                        .HasMany<TargetGroup>(home => (IEnumerable<TargetGroup>?)home.TargetGroups)
                        .WithMany();

            modelBuilder.Entity<Location>();

            modelBuilder.Entity<TargetGroup>();
        }
    }
}