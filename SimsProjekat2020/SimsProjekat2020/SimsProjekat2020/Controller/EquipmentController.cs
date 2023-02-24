using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class EquipmentController : IController<Equipment, string>
    {
        EquipmentService service;

        public EquipmentController(EquipmentService service)
        {
            this.service = service;
        }
        public Equipment Create(Equipment entity)
        {
            return service.Create(entity);
        }

        public void Delete(Equipment entity)
        {
            throw new NotImplementedException();
        }

        
        public Equipment Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Equipment entity)
        {
            throw new NotImplementedException();
        }
    }
}
