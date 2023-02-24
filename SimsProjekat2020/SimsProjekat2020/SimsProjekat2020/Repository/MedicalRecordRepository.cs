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
    public class MedicalRecordRepository : CSVRepository<MedicalRecord, string>
    {
        public MedicalRecordRepository(string entityName, ICSVStream<MedicalRecord> stream, ISequencer<string> sequencer) : base(entityName,stream, sequencer)
        {
        }
    }
}
