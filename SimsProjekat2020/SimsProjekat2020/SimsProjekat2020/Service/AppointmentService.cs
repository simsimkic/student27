using Model;
using SimsProjekat2020.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class AppointmentService : IService<Appointment, long>
    {
        private AppointmentRepository repo;
        public AppointmentService(AppointmentRepository apRepo) {
            repo = apRepo;
        }
        public Appointment Create(Appointment entity)
        {
            return repo.Create(entity);
        }

        public void Delete(Appointment entity)
        {
            repo.Delete(entity);
        }

        public Appointment Get(long id)
        {
            return repo.Get(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return GetAll();
        }

        public void Update(Appointment entity)
        {
            repo.Update(entity);
        }
    }
}
