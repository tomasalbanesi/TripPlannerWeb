using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace TripPlannerWeb.Data.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filtro);
        Task<TEntity> Create(TEntity entidad);
        Task<bool> Edit(TEntity entidad);
        Task<bool> Delete (TEntity entidad);
        Task<IQueryable<TEntity>> List(Expression<Func<TEntity, bool>> filtro = null);

    }
}
