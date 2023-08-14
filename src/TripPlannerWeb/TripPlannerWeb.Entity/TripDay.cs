using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class TripDay : BaseEntity
    {
        public int TripDayId { get; set; }
        public int TripId { get; set; }
        public int DayOrderNumber { get; set; } // 1,2,3,4,5,6,7,8,9....
        public DateTime Date { get; set; }

        // Relaciones
        public virtual Trip Trip { get; set; }
        public virtual ICollection<DayPlanning> DayPlannings { get; set; }
    }
}
