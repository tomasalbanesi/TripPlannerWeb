using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class Trip : BaseEntity
    {
        public int TripId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relaciones
        public virtual ICollection<TripDay> TripDays { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
    }
}
