using System;
using System.Collections.Generic;
using System.Linq;

namespace CarroAPI.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
        private static List<TEntity> _data;

        private static object _sincobject = new object();

        public Repository()
        {
            if(_data == null)
            {
                lock(_sincobject)
                {
                    if(_data == null)
                    {
                        _data = new List<TEntity>();
                    }
                }
            }
        }


        public IEnumerable<TEntity> GetbyMarca(string marca)
        {
            return null;
        }

        public void Save(TEntity entity)
        {
            _data.Add(entity);
        }

        public List<TEntity> find(Func<TEntity, bool> predicate)
        {
            return _data.Where(predicate).ToList();
        }
    }
}
