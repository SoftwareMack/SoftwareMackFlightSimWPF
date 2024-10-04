using Microsoft.EntityFrameworkCore;
using SoftwareMackFlightSimBackend.Models;

namespace SoftwareMackFlightSimBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext(DbContextOptionsBuilder<AppDbContext> options)
        {
            Options = options;
        }

        public DbSet<FlightParameter> FlightParameters { get; set; }
        public DbSet<WindSpeedUpdate> WindSpeedUpdates { get; set; }
        public DbContextOptionsBuilder<AppDbContext> Options { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightParameter>().HasData(
                new FlightParameter { Id = 1, Name = "Altitude", Value = 30000, Unit = "Feet" },
                new FlightParameter { Id = 2, Name = "Speed", Value = 550, Unit = "Knots" },
                new FlightParameter { Id = 3, Name = "Wind Speed", Value = 10, Unit = "MPH" }
            );
        }
    }
}
