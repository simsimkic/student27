using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class AppointmentController : IController<Appointment, long>
    {
        AppointmentService service;

        public AppointmentController(AppointmentService service)
        {
            this.service = service;
        }

        public Appointment Create(Appointment entity)
        {
            return service.Create(entity);
        }

        public void Delete(Appointment entity)
        {
            service.Delete(entity);
        }

        public Appointment Get(long id)
        {
            return service.Get(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return service.GetAll();
        }

        public void Update(Appointment entity)
        {
            service.Update(entity);
        }
    }
}
