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
    public class TripDayConfiguration : IEntityTypeConfiguration<TripDay>
    {
        public void Configure(EntityTypeBuilder<TripDay> builder)
        {
            builder.ToTable("TripDays");
            builder.HasKey(d => d.TripDayId);

            builder.HasOne(d => d.Trip)
                .WithMany(t => t.TripDays)
                .HasForeignKey(d => d.TripId);
        }
    }
}
