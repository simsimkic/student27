using Model;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class AddressService : IService<Adress, long>
    {
        private readonly IAddressRepository _repository;
        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }
        public Adress Create(Adress address) => _repository.Create(address);
        public void Delete(Adress address) => _repository.Delete(address);
        public Adress Get(long id) => _repository.Get(id);
        public IEnumerable<Adress> GetAll() => _repository.GetAll();
        public void Update(Adress address) => _repository.Update(address);
    }
}
