using CarroAPI.Business;
using CarroAPI.Domain;
using CarroAPI.Repository;
using System;
using System.Collections.Generic;

namespace CarroAPI.Service
{
    
    public class CarroServices
    {
        private readonly IRepository<Carro> _carrorepository;
        private readonly CarroBusiness _carroBusiness;

        public CarroServices(IRepository<Carro> carrorepository, CarroBusiness carrobusiness)
        {
            _carrorepository = carrorepository;
            _carroBusiness = carrobusiness;
        }

        public void save(Carro carro)
        {
            _carroBusiness.save(carro);
        }

        public List<Carro> GetbyMarca(string marca)
        {
            var carro = _carrorepository.find(x => x.Marca == marca);

            return carro;
        }

    }
}
