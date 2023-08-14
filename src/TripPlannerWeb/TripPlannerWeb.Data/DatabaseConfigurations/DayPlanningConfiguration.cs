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
    public class DayPlanningConfiguration : IEntityTypeConfiguration<DayPlanning>
    {
        public void Configure(EntityTypeBuilder<DayPlanning> builder)
        {
            builder.ToTable("DayPlannings");
            builder.HasKey(p => p.DayPlanningId);

            builder.HasOne(p => p.TripDay)
                .WithMany(d => d.DayPlannings)
                .HasForeignKey(p => p.TripDayId);

            builder.HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey(p => p.CountryId);
        }
    }
}
