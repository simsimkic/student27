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
    public class EquipmentRepository : CSVRepository<Equipment, string>
    {
        public EquipmentRepository(string entityName, ICSVStream<Equipment> stream, ISequencer<string> sequencer) 
            : base(entityName, stream, sequencer)
        {
        }
    }
}
