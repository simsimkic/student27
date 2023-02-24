using Model;
using SimsProjekat2020.Repository;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Sequncer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class EquipmentService : IService<Equipment, string>
    {
        public EquipmentRepository repo;

        public EquipmentService(EquipmentRepository equipmentRepository)
        {
            repo = equipmentRepository;
        }
        public Equipment Create(Equipment entity)
        {
            return repo.Create(entity);
        }

        public void Delete(Equipment entity)
        {
            repo.Delete(entity);
        }

        public Equipment Get(string id)
        {
            return repo.Get(id);
        }

        public IEnumerable<Equipment> GetAll()
        {
            return GetAll();
        }

        public void Update(Equipment entity)
        {
            repo.Update(entity);
        }
    }
}
