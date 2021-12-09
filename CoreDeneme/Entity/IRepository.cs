using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Entity
{
    public interface IRepository<TEntity> 
    {
        IQueryable<TEntity> GetAll();
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);

    }
}
