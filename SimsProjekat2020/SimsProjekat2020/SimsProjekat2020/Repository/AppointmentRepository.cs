using Model;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Sequncer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository
{
    public class AppointmentRepository : CSVRepository<Appointment, long>
    {

        public AppointmentRepository(string entityName, ICSVStream<Appointment> stream, ISequencer<long> sequencer) : base(entityName, stream, sequencer)
        {
        }
    }
}
