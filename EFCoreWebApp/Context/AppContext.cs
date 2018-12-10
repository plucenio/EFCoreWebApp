using EFCoreWebApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebApp.Context
{
    public class AppContext : DbContext
    {
        public DbSet<City> Cities{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "Torres" });
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = "Porto Alegre" });
            modelBuilder.Entity<City>().HasData(new City { Id = 3, Name = "Canoas" });
            modelBuilder.Entity<City>().HasData(new City { Id = 4, Name = "Viamão" });
        }
    }
}
