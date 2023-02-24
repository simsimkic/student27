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
    public class PatientRepository : CSVRepository<Patient, string>
    {
        public PatientRepository(string entityName, ICSVStream<Patient> stream, ISequencer<string> sequencer) : base(entityName, stream, sequencer)
        {
        }
    }
}
