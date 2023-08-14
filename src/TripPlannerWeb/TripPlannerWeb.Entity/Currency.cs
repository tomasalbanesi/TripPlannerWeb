using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class Currency : BaseEntity
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal UsdExchangeRate { get; set; } // 1 USD = UsdExhangeRate de la moneda ingresada
        
        // Propiedad de navegación para la relación con Budget
        public virtual ICollection<Budget> Budgets { get; set; }
    }
}
