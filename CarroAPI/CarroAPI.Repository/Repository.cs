using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;


namespace CarroAPI.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
         public IEnumerable<TEntity> GetbyMarca(string marca)
        {
            var conn = Utilities.ConnectionFactory.GetConnection();

            var result = conn.Query<TEntity>(marca);

            var res = conn.Query<TEntity>("insert");

            return result;
        }

        public void Save(TEntity entity, string query)
        {
           
        }

        public List<TEntity> find(Func<TEntity, bool> predicate)
        {
            return null;
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
