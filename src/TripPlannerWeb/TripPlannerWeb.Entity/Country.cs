using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlannerWeb.Entity
{
    public class Country : BaseEntity
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string IsoCodeAlpha3 { get; set; }
        public string IsoCodeAlpha2 { get; set; }
        public int IsoCodeNum { get; set; }
    }
}
