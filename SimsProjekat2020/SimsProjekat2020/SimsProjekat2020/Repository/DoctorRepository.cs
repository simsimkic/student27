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
    public class DoctorRepository : CSVRepository<Doctor, long>
    {
        
        public DoctorRepository(string entityName, ICSVStream<Doctor> stream, ISequencer<long> sequencer) : base(entityName, stream, sequencer)
        {
            
        }
    }
}
