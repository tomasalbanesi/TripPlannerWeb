using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class Budget : BaseEntity
    {
        public int BudgetId { get; set; }
        public DateTime Date { get; set; }
        public int CurrencyId { get; set; }
        public int TripId { get; set; }

        // Relaciones
        public virtual Currency Currency { get; set; }
        public virtual ICollection<BudgetItem> Items { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
