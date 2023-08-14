using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlannerWeb.Entity;

namespace TripPlannerWeb.Logic.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> List();
        Task<Country> Create(Country entidad);
        Task<Country> Edit(Country entidad);
        Task<bool> Delete(int id);
    }
}
