using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using TripPlannerWeb.Data.DatabaseConfigurations;
using TripPlannerWeb.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlannerWeb.Data.DatabaseContext
{
    public class TripPlannerWebDbContext : DbContext
    {
        public TripPlannerWebDbContext(DbContextOptions<TripPlannerWebDbContext> options) : base(options) { }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DayPlanning> DayPlannings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripDay> TripDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurations for each entity
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new BudgetConfiguration());
            modelBuilder.ApplyConfiguration(new BudgetItemConfiguration());
            modelBuilder.ApplyConfiguration(new TripConfiguration());
            modelBuilder.ApplyConfiguration(new TripDayConfiguration());
            modelBuilder.ApplyConfiguration(new DayPlanningConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }

}
