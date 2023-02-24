using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class CityController : IController<City, string>
    {
        private readonly IService<City, string> _service;

        public CityController(IService<City, string> service)
        {
            _service = service;
        }
        public City Create(City city) => _service.Create(city);

        public void Delete(City city) => _service.Delete(city);

        public City Get(string id) => _service.Get(id);
        public IEnumerable<City> GetAll() => _service.GetAll();
        public void Update(City city) => _service.Update(city);
    }
}
