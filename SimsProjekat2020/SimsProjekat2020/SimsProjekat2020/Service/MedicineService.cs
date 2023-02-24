using Model;
using SimsProjekat2020.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SimsProjekat2020.Service
{
    public class MedicineService : IService<Medicine, string>
    {
       private MedicineRepository repo;
        public MedicineService(MedicineRepository medicineRepository)
        {
            repo = medicineRepository;
        }
        public Medicine Create(Medicine entity)
        {
            return repo.Create(entity);
        }

        public void Delete(Medicine entity)
        {
            repo.Delete(entity);
        }

        public Medicine Get(string id)
        {
            return repo.Get(id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return GetAll();
        }

        public void Update(Medicine entity)
        {
            repo.Update(entity);
        }
    }
}
