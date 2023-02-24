using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class MedicineController : IController<Medicine, string>
    {
        MedicineService service;

        public MedicineController(MedicineService service)
        {
            this.service = service;
        }

        public Medicine Create(Medicine entity)
        {
            return service.Create(entity);
        }

        public void Delete(Medicine entity)
        {
            service.Delete(entity);
        }

        public Medicine Get(string id)
        {
            return service.Get(id);
        }


        public IEnumerable<Medicine> GetAll()
        {
            return service.GetAll();
        }

        public void Update(Medicine entity)
        {
            service.Update(entity);
        }
    }
}
