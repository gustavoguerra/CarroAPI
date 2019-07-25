using CarroAPI.Domain;
using CarroAPI.Repository;
using System;
using System.Collections.Generic;

namespace CarroAPI.Business
{
    public class CarroBusiness
    {
        private readonly IRepository<Carro> _carrorepository;

        public CarroBusiness(IRepository<Carro> carrorepository)
        {
            _carrorepository = carrorepository;
        }

        public void save(Carro carro)
        {
            _carrorepository.Save(carro);
        }

        public IEnumerable<Carro> Getall()
        {
            var table = "Carro";
            var getall = _carrorepository.GetbyMarca($"select * from {table}");

            return getall;
        }        
    }
}
