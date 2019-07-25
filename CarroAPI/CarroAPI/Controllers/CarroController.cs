using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarroAPI.Domain;
using CarroAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
       private readonly CarroServices _carroservices;
       

        public CarroController(CarroServices carroservices)
        {
            _carroservices = carroservices;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{marca}")]
        public ActionResult<IEnumerable<Carro>> Get(string marca)
        {
            var carro = _carroservices.GetbyMarca(marca);

            return carro.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Carro value)
        {
          //  _carroservices.save(value);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
