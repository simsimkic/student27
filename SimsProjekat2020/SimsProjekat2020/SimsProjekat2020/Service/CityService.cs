using Model;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class CityService : IService<City, string>
    {
        private readonly ICityRepository _repository;
        public CityService(ICityRepository repository)
        {
            _repository = repository;
        }
        public City Create(City city) => _repository.Create(city);
        public void Delete(City city) => _repository.Delete(city);
        public City Get(string id) => _repository.Get(id);
        public IEnumerable<City> GetAll() => _repository.GetAll();
        public void Update(City city) => _repository.Update(city);
    }
}
