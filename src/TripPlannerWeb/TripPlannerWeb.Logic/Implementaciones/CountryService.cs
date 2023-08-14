using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlannerWeb.Data.Interfaces;
using TripPlannerWeb.Entity;
using TripPlannerWeb.Logic.Interfaces;

namespace TripPlannerWeb.Logic.Implementaciones
{
    public class CountryService : ICountryService
    {

        private readonly IGenericRepository<Country> _repository;

        public CountryService(IGenericRepository<Country> repository)
        {
            _repository = repository;
        }

        public async Task<List<Country>> List()
        {
            IQueryable<Country> query = await _repository.List();
            return query.ToList();
        }

        public Task<Country> Create(Country entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Edit(Country entidad)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
