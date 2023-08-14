using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // Propiedad de navegación para la relación con BudgetItem
        public virtual ICollection<BudgetItem> BudgetItems { get; set; }
    }
}
