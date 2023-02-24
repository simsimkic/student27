using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    class MedicalRecordController : IController<MedicalRecord, long>
    {
        MedicalRecordService service;

        public MedicalRecordController(MedicalRecordService service)
        {
            this.service = service;
        }
        public MedicalRecord Create(MedicalRecord entity)
        {
            return service.Create(entity);
        }

        public void Delete(MedicalRecord entity)
        {
            service.Delete(entity);
        }

        public MedicalRecord Get(long id)
        {
            return service.Get(id);
        }

        public IEnumerable<MedicalRecord> GetAll()
        {
            return service.GetAll();
        }

        public void Update(MedicalRecord entity)
        {
            service.Update(entity);
        }
    }
}
