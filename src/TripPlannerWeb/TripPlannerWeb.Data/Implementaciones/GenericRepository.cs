using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TripPlannerWeb.Data.DatabaseContext;
using TripPlannerWeb.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace TripPlannerWeb.Data.Implementaciones
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly TripPlannerWebDbContext _dbContext;

        public GenericRepository(TripPlannerWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filtro)
        {
            try
            {
                TEntity entidad = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filtro);
                return entidad;
            }
            catch {
                throw;
            }
        }

        public async Task<TEntity> Create(TEntity entidad)
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entidad);
                await _dbContext.SaveChangesAsync();
                return entidad;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Edit(TEntity entidad)
        {
            try
            {
                _dbContext.Update(entidad);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Delete(TEntity entidad)
        {
            try
            {
                _dbContext.Remove(entidad);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IQueryable<TEntity>> List(Expression<Func<TEntity, bool>> filtro = null)
        {
            IQueryable<TEntity> queryEntidad = filtro == null ? _dbContext.Set<TEntity>() : _dbContext.Set<TEntity>().Where(filtro);
            return queryEntidad;
        }


        
    }
}
