using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface IAppointmentRepository : IRepository<Appointment, long>
    {
        IEnumerable<Appointment> GetAppointmentsByDate(DateTime date);
        IEnumerable<Appointment> GetAppointmentsByDoctor(Doctor doctor);
    }
}
