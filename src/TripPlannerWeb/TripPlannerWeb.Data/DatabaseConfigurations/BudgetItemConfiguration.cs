using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlannerWeb.Entity;

namespace TripPlannerWeb.Data.DatabaseConfigurations
{
    public class BudgetItemConfiguration : IEntityTypeConfiguration<BudgetItem>
    {
        public void Configure(EntityTypeBuilder<BudgetItem> builder)
        {
            builder.ToTable("BudgetItems");
            builder.HasKey(i => i.BudgetItemId);

            builder.HasOne(i => i.Budget)
                .WithMany(b => b.Items)
                .HasForeignKey(i => i.BudgetId);

            builder.HasOne(i => i.Category)
                .WithMany(c => c.BudgetItems)
                .HasForeignKey(i => i.CategoryId);
        }
    }
}
