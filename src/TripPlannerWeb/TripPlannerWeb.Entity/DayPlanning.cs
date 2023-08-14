using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class DayPlanning : BaseEntity
    {
        public int DayPlanningId { get; set; }
        public int TripDayId { get; set; }
        public string CodeUtc { get; set; }
        public DateTime Time { get; set; } // Hora de realización
        public TimeSpan? Duration { get; set; } // Duración, es opcional
        public string Activity { get; set; }
        public int CountryId { get; set; } // País que estoy visitando

        public virtual TripDay TripDay { get; set; }
        public virtual Country Country { get; set; }
    }
}
