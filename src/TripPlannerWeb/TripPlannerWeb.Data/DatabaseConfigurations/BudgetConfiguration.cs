using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlannerWeb.Entity;

namespace TripPlannerWeb.Data.DatabaseConfigurations
{
    public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            builder.ToTable("Budgets");
            builder.HasKey(b => b.BudgetId);

            builder.HasOne(b => b.Currency)
                .WithMany(c => c.Budgets)
                .HasForeignKey(b => b.CurrencyId);

            builder.HasOne(b => b.Trip)
                .WithMany(t => t.Budgets)
                .HasForeignKey(b => b.TripId);
        }
    }
}
