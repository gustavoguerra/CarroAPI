using System;
using System.Collections.Generic;
using System.Text;

namespace CarroAPI.Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetbyMarca(string marca);

        void Save(TEntity entity);

        List<TEntity> find(Func<TEntity,bool> predicate);
    }
}
