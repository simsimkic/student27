using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class AddressController : IController<Adress, long>
    {
        private readonly IService<Adress, long> _service;

        public AddressController(IService<Adress, long> service)
        {
            _service = service;
        }
        public Adress Create(Adress address) => _service.Create(address);
        public void Delete(Adress address) => _service.Delete(address);
        public Adress Get(long id) => _service.Get(id);
        public IEnumerable<Adress> GetAll() => _service.GetAll();
        public void Update(Adress address) => _service.Update(address);
    }
}
