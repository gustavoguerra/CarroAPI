using CarroAPI.Domain;
using CarroAPI.Repository;
using System;

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
    }
}
