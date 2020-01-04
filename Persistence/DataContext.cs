using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seed data - adding data into  a migration class
            builder.Entity<WeatherForecast>()
                .HasData(
                    new WeatherForecast { Id = 1, Date = DateTime.Today.AddDays(1), Summary = "This is the new weather", TemperatureC = 29 },
                    new WeatherForecast { Id = 2, Date = DateTime.Today.AddDays(2), Summary = "This is so normal", TemperatureC = 35 },
                    new WeatherForecast { Id = 3, Date = DateTime.Today.AddDays(3), Summary = "This is a really cold weather", TemperatureC = 3 }
                );
        }
    }
}
