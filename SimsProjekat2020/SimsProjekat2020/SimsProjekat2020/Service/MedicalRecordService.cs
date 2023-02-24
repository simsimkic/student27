using Model;
using SimsProjekat2020.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    class MedicalRecordService : IService<MedicalRecord, long>
    {
        private MedicalRecordRepository repo;

        public MedicalRecordService(MedicalRecordRepository medicalRecordRepo)
        {
            repo = medicalRecordRepo;
        }
        public MedicalRecord Create(MedicalRecord entity)
        {
            return repo.Create(entity);
        }

        public void Delete(MedicalRecord entity)
        {
            repo.Delete(entity);
        }

        public MedicalRecord Get(long id)
        {
            return repo.Get(id.ToString());
        }

        public IEnumerable<MedicalRecord> GetAll()
        {
            return GetAll();
        }

        public void Update(MedicalRecord entity)
        {
            repo.Update(entity);
        }
    }
}
