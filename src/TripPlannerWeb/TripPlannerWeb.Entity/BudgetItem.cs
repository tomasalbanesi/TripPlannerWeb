using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class BudgetItem : BaseEntity
    {
        public int BudgetItemId { get; set; }
        public int BudgetId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal { get; set; }

        // Relaciones
        public virtual Budget Budget { get; set; }
        public virtual Category Category { get; set; }
    }

}
