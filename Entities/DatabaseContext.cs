using Microsoft.EntityFrameworkCore;

namespace travelAPI.Entities
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<Continent> Continent { get; set; }
        public DbSet<Monument> Monument { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(c => c.CountryName)
                .IsRequired();

            modelBuilder.Entity<Country>()
                .Property(c => c.Capitol)
                .IsRequired();

            modelBuilder.Entity<Continent>()
                .Property(c => c.ContinentName)
                .IsRequired();

            modelBuilder.Entity<Monument>()
                .Property(m => m.MonumentName)
                .IsRequired();
        }
    }
}